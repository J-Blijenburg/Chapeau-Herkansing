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
            string query = "SELECT [Table].[TableId], [Table].[Number], [Table].[Status], [TableStatus].[Status] as [TableStatus] FROM [Table] INNER JOIN [TableStatus] ON [Table].[Status] = [TableStatus].[TableStatusId]";
            return ReadTables(ExecuteSelectQuery(query));
        }

        public bool UpdateTableStatus(Table table)
        {
            string query = "UPDATE [Table] SET [Status] = @Status WHERE [TableId] = @TableId";
            SqlParameter[] sqlParameters = {
                new SqlParameter("@Status", SqlDbType.Int) { Value = (int)table.Status },
                new SqlParameter("@TableId", SqlDbType.Int) { Value = table.TableId }
            };

            try
            {
                ExecuteEditQuery(query, sqlParameters);
                return true;
            }
            catch
            {
                return false;
            }
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
                        Status = (TableStatus)dr["Status"]
                    };

                    tables.Add(table);
                }
            }

            return tables;
        }
    }
}
