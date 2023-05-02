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
        public void CreateReceipt(Receipt receipt)
        {
            string query = "INSERT INTO Receipt (ReceiptDateTime, Feedback, EmployeeId, TableId, LowVatPrice, HighVatPrice, TotalPrice, Tip, IsHandled, PaymentId) VALUES (@ReceiptDateTime, @Feedback, @EmployeeId, @TableId, @LowVatPrice, @HighVatPrice, @TotalPrice, @Tip, @IsHandled, @PaymentId); ";
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
            ExecuteEditQuery(query, sqlParameters);


        }




        //public int GetLastInsertedReceipt()
        //{
        //    string query = "SELECT ReceiptId, ReceiptDateTime, Feedback, EmployeeId, TableId, LowVatPrice, HighVatPrice, TotalPrice, Tip, IsHandled, PaymentId " +
        //                    "FROM [Receipt] " +
        //                    "WHERE ReceiptId = (SELECT MAX(ReceiptId) FROM [Receipt]);";


        //}
    }
}
