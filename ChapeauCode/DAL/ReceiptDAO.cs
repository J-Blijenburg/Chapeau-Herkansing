using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class ReceiptDAO : BaseDao
    {
        public Receipt CreateReceipt(Table table)
        {
            //de employee moet nog worden aangepast aan de gebruiker die is ingelogd
            Employee employee = new Employee();
            employee.EmployeeId = 1;

            //de payment moet nog worden aangepast aan de betaalmethode die de gebruiker heeft gekozen
            Payment payment = new Payment();
            payment.PaymentId = 1;

            //LET OP: Deze methode is nog niet af. moet nog worden aangepast aan gebruikers etc...
            Receipt receipt = new Receipt();
            receipt.ReceiptDateTime = DateTime.Now;
            receipt.Feedback = "";
            receipt.Employee = employee;
            receipt.Table = table;
            receipt.LowVatPrice = 0;
            receipt.HighVatPrice = 0;
            receipt.TotalPrice = 0;
            receipt.Tip = 0;
            receipt.IsHandled = false;
            receipt.Payment = payment;


            receipt.ReceiptId = InsertReceipt(receipt);

            return receipt;
        }
        private int InsertReceipt(Receipt receipt)
        {
            //https://stackoverflow.com/questions/20117825/executescalar-call-throwing-exception-object-reference-not-set-to-an-instance-o
            string query = "INSERT INTO Receipt (ReceiptDateTime, Feedback, EmployeeId, TableId, LowVatPrice, HighVatPrice, TotalPrice, Tip, IsHandled, PaymentId) VALUES (@ReceiptDateTime, @Feedback, @EmployeeId, @TableId, @LowVatPrice, @HighVatPrice, @TotalPrice, @Tip, @IsHandled, @PaymentId); SELECT CAST(scope_identity() AS int)";
            SqlParameter[] sqlParameters;
            sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@ReceiptDateTime", receipt.ReceiptDateTime),
                new SqlParameter("@Feedback", receipt.Feedback),
                new SqlParameter("@EmployeeId", receipt.Employee.EmployeeId),
                new SqlParameter("@TableId", receipt.Table.TableId),
                new SqlParameter("@LowVatPrice", receipt.LowVatPrice),
                new SqlParameter("@HighVatPrice", receipt.HighVatPrice),
                new SqlParameter("@TotalPrice", receipt.TotalPrice),
                new SqlParameter("@Tip", receipt.Tip),
                new SqlParameter("@IsHandled", receipt.IsHandled),
                new SqlParameter("@PaymentId", receipt.Payment.PaymentId),
            };
            //by using the method executeinsertqueryandreturnid we can get the id of the last inserted receipt
            
            return ExecuteInsertQueryAndReturnId(query, sqlParameters);

            //Het was nog een twijfel geval wat handiger was. Alleen het id return of het gehele object returnen.
        }

        public Receipt GetReceiptByTable(Table table)
        {
            string query = "SELECT RT.ReceiptId, RT.ReceiptDateTime, RT.Feedback, EM.EmployeeId, EM.FirstName, EM.LastName, EM.EmployeeNumber, EM.Password, EM.IsActive, EM.RegistrationDate, ER.Role, TE.TableId, TE.Number, TS.Status, RT.LowVatPrice, RT.HighVatPrice, RT.TotalPrice, RT.Tip, RT.IsHandled, PT.PaymentId, PT.IsPaid " +
                "FROM [Receipt] AS RT " +
                "JOIN [Employee] AS EM ON RT.EmployeeId = EM.EmployeeId " +
                "JOIN [EmployeeRole] AS ER ON EM.Role = ER.EmployeeRoleId " +
                "JOIN [Table] AS TE ON RT.TableId = TE.TableId " +
                "JOIN [TableStatus] AS TS ON TE.Status = TS.TableStatusId " +
                "JOIN [Payment] AS PT ON RT.PaymentId  = PT.PaymentId " +
                "WHERE TE.Number = @TableId AND RT.IsHandled = 0";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
        new SqlParameter("@TableId", table.Number)
            };

            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);

            if (dataTable.Rows.Count == 0)
            {
                return CreateReceipt(table);
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
                receipt.IsHandled = (bool)dr["IsHandled"];
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
