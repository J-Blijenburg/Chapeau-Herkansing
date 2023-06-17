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
            receipt.TotalPrice = 0;
            receipt.Tip = 0;
            receipt.Payment = payment;

            receipt.Payment.PaymentId = InsertNewPayment();
            
            receipt.ReceiptId = InsertNewReceipt(receipt);

            return receipt;
        }
        private int InsertNewReceipt(Receipt receipt)
        {
            //https://stackoverflow.com/questions/20117825/executescalar-call-throwing-exception-object-reference-not-set-to-an-instance-o
            string query = "INSERT INTO Receipt (ReceiptDateTime, Feedback, EmployeeId, TableNumber, LowVatPrice, HighVatPrice, TotalPrice, Tip, PaymentId) VALUES (@ReceiptDateTime, @Feedback, @EmployeeId, @TableNumber, @LowVatPrice, @HighVatPrice, @TotalPrice, @Tip, @PaymentId); SELECT CAST(scope_identity() AS int)";
            SqlParameter[] sqlParameters;
            sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@ReceiptDateTime", receipt.ReceiptDateTime),
                new SqlParameter("@Feedback", receipt.Feedback),
                new SqlParameter("@EmployeeId", receipt.Employee.EmployeeId),
                new SqlParameter("@TableNumber", receipt.Table.Number),
                new SqlParameter("@LowVatPrice", receipt.LowVatPrice),
                new SqlParameter("@HighVatPrice", receipt.HighVatPrice),
                new SqlParameter("@TotalPrice", receipt.TotalPrice),
                new SqlParameter("@Tip", receipt.Tip),
                new SqlParameter("@PaymentId", receipt.Payment.PaymentId),
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
        // TODO update receipt in the db, with an update set query
        public void UpdateReceiptPaid(Receipt receipt)
        {
            //UpdateReceiptTable(receipt);
            //UpdatePaymentTables(receipt);

            string updateQuery = @"
             UPDATE Receipt
             SET
                Feedback = @Feedback,
                LowVatPrice = @LowVatPrice,
                HighVatPrice = @HighVatPrice,
                TotalPrice = @TotalPrice,
                Tip = @Tip,
                Payment.isPaid = @isPaid,
                Payment.PaymentMethodId = @PaymentMethodId
                FROM Receipt
                INNER JOIN Payment ON Receipt.PaymentId = Payment.PaymentId
                WHERE Receipt.ReceiptId = @ReceiptId";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
          new SqlParameter("@ReceiptId", receipt.ReceiptId),
                new SqlParameter("@Feedback", receipt.Feedback),
                new SqlParameter("@LowVatPrice", receipt.LowVatPrice),
                new SqlParameter("@HighVatPrice", receipt.HighVatPrice),
                new SqlParameter("@TotalPrice", receipt.TotalPrice),
                new SqlParameter("@Tip", receipt.Tip),
            new SqlParameter("@PaymentId", receipt.Payment.PaymentId),
            new SqlParameter("@isPaid", receipt.Payment.IsPaid),
            new SqlParameter("@PaymentMethodId", receipt.Payment.PaymentMethod)
            };
            ExecuteEditQuery(updateQuery, sqlParameters);
        }
        public void UpdateReceiptTable (Receipt receipt) { //tijdelijk

            string updateReceiptQuery = @"
             UPDATE Receipt
             SET
                Feedback = @Feedback,
                LowVatPrice = @LowVatPrice,
                HighVatPrice = @HighVatPrice,
                TotalPrice = @TotalPrice,
                Tip = @Tip,
                Payment.isPaid = @isPaid,
                Payment.PaymentMethodId = @PaymentMethodId";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@ReceiptId", receipt.ReceiptId),
                new SqlParameter("@Feedback", receipt.Feedback),
                new SqlParameter("@LowVatPrice", receipt.LowVatPrice),
                new SqlParameter("@HighVatPrice", receipt.HighVatPrice),
                new SqlParameter("@TotalPrice", receipt.TotalPrice),
                new SqlParameter("@Tip", receipt.Tip),
            };
            ExecuteEditQuery(updateReceiptQuery, sqlParameters);
        }
        public void UpdatePaymentTables (Receipt receipt) //tijdelijk
        {
            string updatePaymentQuery = @"
             UPDATE Payment, 
             SET
                Payment.isPaid = @isPaid,
                Payment.PaymentMethodId = @PaymentMethodId";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@ReceiptId", receipt.ReceiptId),
                new SqlParameter("@Feedback", receipt.Feedback),
                new SqlParameter("@LowVatPrice", receipt.LowVatPrice),
                new SqlParameter("@HighVatPrice", receipt.HighVatPrice),
                new SqlParameter("@TotalPrice", receipt.TotalPrice),
                new SqlParameter("@Tip", receipt.Tip),
            };
            ExecuteEditQuery(updatePaymentQuery, sqlParameters);
        }

        public Receipt GetReceiptByTable(Table table, Employee employee)
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

            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);

            if (dataTable.Rows.Count == 0)
            {
                return CreateNewReceipt(table, employee);
            }
            return CreateExistingReceipt(dataTable);
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
                receipt.TotalPrice = (double)dr["TotalPrice"];
                receipt.Tip = (double)dr["Tip"];
                receipt.Payment = new Payment()
                {
                    PaymentId = (int)dr["PaymentId"],
                    IsPaid = (bool)dr["IsPaid"]
                };

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
