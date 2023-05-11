using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Model;

namespace DAL
{
    public class TableDAO : BaseDao
    {
        public List<Table> GetTables()
        {
            string query = @"SELECT [Table].[TableId], [Table].[Number], [Table].[Status], [TableStatus].[Status] as [TableStatus],
                             COUNT([Order].[OrderId]) as [UndeliveredOrdersCount]
                             FROM [Table]
                             LEFT JOIN [Receipt] ON [Table].[TableId] = [Receipt].[TableId]
                             LEFT JOIN [Order] ON [Receipt].[ReceiptId] = [Order].[ReceiptId] AND [Order].[Status] = @DeliveredStatus
                             LEFT JOIN [TableStatus] ON [Table].[Status] = [TableStatus].[TableStatusId]
                             GROUP BY [Table].[TableId], [Table].[Number], [Table].[Status], [TableStatus].[Status]";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@DeliveredStatus", (int)OrderStatus.Delivered)
            };

            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public void UpdateTableStatus(int tableNumber, TableStatus newStatus)
        {
            string query = "UPDATE [Table] SET Status = @NewStatus WHERE Number = @TableNumber";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@TableNumber", tableNumber),
                new SqlParameter("@NewStatus", (int)newStatus)
            };

            ExecuteEditQuery(query, sqlParameters);
        }


        private List<Table> ReadTables(DataTable dataTable)
        {
            List<Table> tables = new List<Table>();

            if (dataTable != null)
            {
                foreach (DataRow dr in dataTable.Rows)
                {
                    Table table = new Table
                    {
                        TableId = (int)dr["TableId"],
                        Number = (int)dr["Number"],
                        Status = (TableStatus)dr["Status"],
                        UndeliveredOrdersCount = (int)dr["UndeliveredOrdersCount"]
                    };


                    tables.Add(table);
                }
            }

            return tables;
        }
    }
}
