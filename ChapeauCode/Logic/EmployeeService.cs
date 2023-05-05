using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Logic
{
    public class EmployeeService
    {
        EmployeeDAO employeeDAO;
        public EmployeeService() { 
            employeeDAO = new EmployeeDAO();
        }

        public string EncryptPassword(string password)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            using var rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, salt, 100000);
            byte[] hash = rfc2898DeriveBytes.GetBytes(32);

            byte[] hashBytes = new byte[48];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 32);

            string savedPasswordHash = Convert.ToBase64String(hashBytes);
            return savedPasswordHash;
        }
        public bool VerifyPassword(string password, string storedPasswordHash)
        {
            byte[] hashBytes = Convert.FromBase64String(storedPasswordHash);

            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);

            using var rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, salt, 100000);
            byte[] hash = rfc2898DeriveBytes.GetBytes(32);

            for (int i = 0; i < 32; i++)
            {
                if (hashBytes[i + 16] != hash[i])
                {
                    return false;
                }
            }

            return true;
        }
        public Employee ValidateEmployeeLogin(string employeeNumber, string providedPassword)
        {
            Employee employee = employeeDAO.GetEmployee(employeeNumber);

            if (employee != null && VerifyPassword(providedPassword, employee.Password))
            {
                return employee;
            }

            return null;
        }





    }
}
