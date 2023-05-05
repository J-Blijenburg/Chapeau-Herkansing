using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class EmployeeDAO : BaseDao
    {

        //Medewerker ophalen
        public Employee GetEmployee(string employeeNumber)
        {
            string query = "SELECT EmployeeId, FirstName, LastName, EmployeeNumber, Password, IsActive, RegistrationDate, Role FROM dbo.Employee WHERE EmployeeNumber = @EmployeeNumber";
            

            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@EmployeeNumber",SqlDbType.VarChar){Value = employeeNumber}
            };
            return ReadTable(ExecuteSelectQuery(query, sqlParameters));
        }

        //Hulp methode om datatable om te zetten in medewerker
        private Employee ReadTable(DataTable dataTable)
        {
            Employee employee = null;

            foreach (DataRow dr in dataTable.Rows)
            {
                employee = new Employee()
                {
                    EmployeeId = (int)dr["EmployeeId"],
                    FirstName = (string)dr["FirstName"],
                    LastName = (string)dr["LastName"],
                    EmployeeNumber = (int)dr["EmployeeNumber"],
                    Password = (string)dr["Password"],
                    IsActive = (bool)dr["IsActive"],
                    RegistrationDate = dr["RegistrationDate"] == DBNull.Value ? (DateTime?)null : (DateTime)dr["RegistrationDate"],
                    Role = (EmployeeRole)dr["Role"]
                };

                break;
            }

            return employee;
        }




    }
}
