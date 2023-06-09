﻿using System;
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
             COUNT([OrderItem].[OrderItemId]) as [UndeliveredOrdersCount] FROM [Table]
             LEFT JOIN [Receipt] ON [Table].[Number] = [Receipt].[TableNumber]
             LEFT JOIN [Order] ON [Receipt].[ReceiptId] = [Order].[ReceiptId] AND [Receipt].[IsHandled] = 0
             LEFT JOIN [OrderItem] ON [Order].[OrderId] = [OrderItem].[OrderId] AND [OrderItem].[OrderItemStatus] != @DeliveredStatus 
              LEFT JOIN [TableStatus] ON [Table].[Status] = [TableStatus].[TableStatusId]
             GROUP BY [Table].[TableId], [Table].[Number], [Table].[Status], [TableStatus].[Status]";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@DeliveredStatus", (int)OrderItemStatus.Delivered)
            };


            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public Table GetTable(int tableNumber)
        {
            string query = @"SELECT [Table].[TableId], [Table].[Number], [Table].[Status], [TableStatus].[Status] as [TableStatus],
             COUNT([OrderItem].[OrderItemId]) as [UndeliveredOrdersCount]
             FROM [Table]
             LEFT JOIN [Receipt] ON [Table].[Number] = [Receipt].[TableNumber]
             LEFT JOIN [Order] ON [Receipt].[ReceiptId] = [Order].[ReceiptId] AND [Receipt].[IsHandled] = 0
             LEFT JOIN [OrderItem] ON [Order].[OrderId] = [OrderItem].[OrderId] AND [OrderItem].[OrderItemStatus] != @DeliveredStatus

             LEFT JOIN [TableStatus] ON [Table].[Status] = [TableStatus].[TableStatusId]
             WHERE [Table].[Number] = @TableNumber
             GROUP BY [Table].[TableId], [Table].[Number], [Table].[Status], [TableStatus].[Status]";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@DeliveredStatus", (int)OrderItemStatus.Delivered),
                new SqlParameter("@TableNumber", tableNumber)
            };

            return ReadTable(ExecuteSelectQuery(query, sqlParameters));
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
        public bool HasUnhandledReceipt(int tableNumber)
        {
            string query = @"SELECT [ReceiptId] FROM [Receipt] WHERE [TableNumber] = @TableNumber AND [IsHandled] = 0";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@TableNumber", tableNumber)
            };

            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);

            
            return dataTable.Rows.Count > 0;
        }

        private Table ReadTable(DataTable dataTable)
        {
            Table table = null;
            if (dataTable != null)
            {
                foreach (DataRow dr in dataTable.Rows)
                {
                    table = new Table
                    {
                        TableId = (int)dr["TableId"],
                        Number = (int)dr["Number"],
                        Status = (TableStatus)dr["Status"],
                        UndeliveredOrdersCount = (int)dr["UndeliveredOrdersCount"]
                    };
                }
            }

            return table;
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
