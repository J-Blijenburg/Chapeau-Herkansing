using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Diagnostics;
using Model;
using System.Collections;

namespace DAL
{
    public class ReceiptDAO : BaseDao
    {
        public Receipt CreateNewReceipt(Table table, Employee employee)
        {
            Payment payment = new Payment();
   
            Receipt receipt = new Receipt();
            receipt.ReceiptDateTime = DateTime.Now;
            receipt.Feedback = "";
            receipt.Employee = employee;
            receipt.Table = table;
            receipt.LowVatPrice = 0;
            receipt.HighVatPrice = 0;
            receipt.TotalPriceExclVat = 0;
            receipt.Tip = 0;
            receipt.IsHandled = false;
            receipt.Payments.Add(payment);
            //receipt.Payment =  payment;
            var paymentId = InsertNewPayment();
            receipt.Payments.ForEach(p => p.PaymentId = paymentId);
            //receipt.Payment.PaymentId = InsertNewPayment();

            receipt.ReceiptId = InsertNewReceipt(receipt);

            return receipt;
        }
        private int InsertNewReceipt(Receipt receipt)
        {
            //https://stackoverflow.com/questions/20117825/executescalar-call-throwing-exception-object-reference-not-set-to-an-instance-o
            string query = "INSERT INTO Receipt (ReceiptDateTime, Feedback, EmployeeId, TableNumber, LowVatPrice, HighVatPrice, TotalPrice, Tip, IsHandled, PaymentId) VALUES (@ReceiptDateTime, @Feedback, @EmployeeId, @TableNumber, @LowVatPrice, @HighVatPrice, @TotalPrice, @Tip, @IsHandled, @PaymentId); SELECT CAST(scope_identity() AS int)";
            SqlParameter[] sqlParameters;
            sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@ReceiptDateTime", receipt.ReceiptDateTime),
                new SqlParameter("@Feedback", receipt.Feedback),
                new SqlParameter("@EmployeeId", receipt.Employee.EmployeeId),
                new SqlParameter("@TableNumber", receipt.Table.Number),
                new SqlParameter("@LowVatPrice", receipt.LowVatPrice),
                new SqlParameter("@HighVatPrice", receipt.HighVatPrice),
                new SqlParameter("@TotalPrice", receipt.TotalPriceExclVat),
                new SqlParameter("@Tip", receipt.Tip),
                new SqlParameter("@IsHandled", receipt.IsHandled),
                new SqlParameter("@PaymentId",  receipt.Payments.First().PaymentId),   /*receipt.Payment.PaymentId*/
            };
            //by using the method executeinsertqueryandreturnid we can get the id of the last inserted receipt

            return ExecuteInsertQueryAndReturnId(query, sqlParameters);
        }

        public int InsertNewPayment() {
            string query = "INSERT INTO Payment (PaymentMethodId, IsPaid) VALUES (@PaymentMethodId, @IsPaid); SELECT CAST(SCOPE_IDENTITY() AS INT) AS LastInsertedId";
            SqlParameter[] sqlParameters;
            sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@PaymentMethodId", PaymentMethod.NoPayment),
                new SqlParameter("@IsPaid", false),
            };

            return ExecuteInsertQueryAndReturnId(query, sqlParameters);
        }
        // update receipt and related tables
        public void UpdateReceiptPaid(Receipt receipt)
        {
            UpdateReceiptTables(receipt);
            UpdatePaymentTables(receipt);
            SettabletoFree(receipt);
            foreach (Payment payment in receipt.Payments)
            {
                string query = "INSERT INTO ReceiptPayment ([PaymentId], [ReceiptId]) VALUES (@PaymentId, @ReceiptId);";
                SqlParameter[] sqlParameters;
                sqlParameters = new SqlParameter[]
                {
                new SqlParameter("@ReceiptId", receipt.ReceiptId),
                new SqlParameter("@PaymentId", receipt.Payments.First().PaymentId),
                };
                ExecuteEditQuery(query, sqlParameters);
            }
        }
        // set table free
        private void SettabletoFree(Receipt receipt)
        {
            
            string updateQuery = @"
             UPDATE [Table]
             SET
               [Table].Status = @TableStatus
                WHERE [Table].Number= @TableNumber";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@TableStatus", TableStatus.Open),
                new SqlParameter("@TableNumber", receipt.Table.TableId)
            };
            ExecuteEditQuery(updateQuery, sqlParameters);
        }
        //update receipt table
        private void UpdateReceiptTables(Receipt receipt)
        {
            string updateQuery = @"
             UPDATE Receipt
             SET
                Feedback = @Feedback,
                LowVatPrice = @LowVatPrice,
                HighVatPrice = @HighVatPrice,
                TotalPrice = @TotalPrice,
                Tip = @Tip,
                IsHandled = @IsHandled
                WHERE Receipt.ReceiptId = @ReceiptId;";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@ReceiptId", receipt.ReceiptId),
                new SqlParameter("@Feedback", receipt.Feedback),
                new SqlParameter("@LowVatPrice", receipt.LowVatPrice),
                new SqlParameter("@HighVatPrice", receipt.HighVatPrice),
                new SqlParameter("@TotalPrice", receipt.TotalPriceExclVat),
                new SqlParameter("@Tip", receipt.Tip),
                new SqlParameter("@IsHandled", receipt.IsHandled)
            };
            ExecuteEditQuery(updateQuery, sqlParameters);
        }
        //update payment table
        private void UpdatePaymentTables(Receipt receipt)
        {
            string updateQuery = @"
             UPDATE Payment
             SET
                IsPaid = @IsPaid,
                PaymentMethodId = @PaymentMethodId
                FROM Payment
                JOIN Receipt ON Payment.PaymentId = Receipt.PaymentId
                WHERE Receipt.ReceiptId = @ReceiptId;";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@PaymentId", receipt.Payments.First().PaymentId),
                new SqlParameter("@IsPaid", receipt.Payments.First().IsPaid),
                new SqlParameter("@PaymentMethodId", receipt.Payments.First().PaymentMethod),
                new SqlParameter("@ReceiptId", receipt.ReceiptId),
            };
            ExecuteEditQuery(updateQuery, sqlParameters);
        }
        public Receipt GetReceiptByTable(Table table)
        {
            return CreateExistingReceipt(GetReceipt(table));
        }
        public Receipt GetReceiptByTableAndEmployee(Table table, Employee employee)
        {
            DataTable dataTable = GetReceipt(table);

            if (dataTable.Rows.Count == 0)
            {
                return CreateNewReceipt(table, employee);
            }
            return CreateExistingReceipt(dataTable);
        }

        private DataTable GetReceipt(Table table)
        {
            string query = "SELECT RT.ReceiptId, RT.ReceiptDateTime, RT.Feedback, EM.EmployeeId, EM.FirstName, EM.LastName, EM.EmployeeNumber, EM.Password, EM.IsActive, EM.RegistrationDate, ER.Role, TE.TableId, TE.Number, TS.Status, RT.LowVatPrice, RT.HighVatPrice, RT.TotalPrice, RT.Tip, PT.PaymentId, PT.IsPaid " +
               "FROM [Receipt] AS RT " +
               "JOIN [Employee] AS EM ON RT.EmployeeId = EM.EmployeeId " +
               "JOIN [EmployeeRole] AS ER ON EM.Role = ER.EmployeeRoleId " +
               "JOIN [Table] AS TE ON RT.TableNumber = TE.Number " +
               "JOIN [TableStatus] AS TS ON TE.Status = TS.TableStatusId " +
               "JOIN [Payment] AS PT ON RT.PaymentId  = PT.PaymentId " +
               "WHERE TE.Number = @TableNumber AND RT.Ishandled = 0";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@TableNumber", table.Number)
            };
            return ExecuteSelectQuery(query, sqlParameters);
        }

        private Receipt CreateExistingReceipt(DataTable dataTable)
        {
            Receipt receipt = new Receipt();

            foreach (DataRow dr in dataTable.Rows)
            {
                receipt.ReceiptId = (int)dr["ReceiptId"];
                receipt.ReceiptDateTime = (DateTime)dr["ReceiptDateTime"];
                receipt.Feedback = (string)dr["Feedback"];
                receipt.Employee = new Employee()
                {
                    EmployeeId = (int)dr["EmployeeId"],
                    FirstName = (string)dr["FirstName"],
                    LastName = (string)dr["LastName"],
                    EmployeeNumber = (int)dr["EmployeeNumber"],
                    Password = (string)dr["Password"],
                    IsActive = (bool)dr["IsActive"],
                    RegistrationDate = DateTime.Now,
                    Role = StringToEmployeeRole((string)dr["Role"])
                };
                receipt.Table = new Table()
                {
                    TableId = (int)dr["TableId"],
                    Number = (int)dr["Number"],
                    Status = StringToTableStatus((string)dr["Status"])
                };
                receipt.LowVatPrice = (double)dr["LowVatPrice"];
                receipt.HighVatPrice = (double)dr["HighVatPrice"];
                receipt.TotalPriceExclVat = (double)dr["TotalPrice"];
                receipt.Tip = (double)dr["Tip"];

                var payment = new Payment()
                {
                    PaymentId = (int)dr["PaymentId"],
                    IsPaid = (bool)dr["IsPaid"]
                };
                    receipt.Payments.Add(payment);

            }
            return receipt;
        }

        private EmployeeRole StringToEmployeeRole(string role)
        {
            switch (role)
            {
                case "Manager":
                    return EmployeeRole.Manager;
                case "Waiter":
                    return EmployeeRole.Waiter;
                case "Chefkok":
                    return EmployeeRole.Chefkok;
                case "Bartender":
                    return EmployeeRole.Bartender;
                default:
                    return EmployeeRole.Waiter;
            }
        }

        private TableStatus StringToTableStatus(string tableStatus)
        {
            switch (tableStatus)
            {
                case "Open":
                    return TableStatus.Open;
                case "Reserved":
                    return TableStatus.Reserved;
                case "Occupied":
                    return TableStatus.Occupied;
                default:
                    return TableStatus.Open;
            }
        }
    }
}
