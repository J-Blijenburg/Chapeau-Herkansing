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
        //https://stackoverflow.com/questions/4181198/how-to-hash-a-password/10402129#10402129
        public string EncryptPassword(string password)
        {
            byte[] salt;
            //Create the salt value with a cryptographic PRNG
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            //Create the salt value with a cryptographic PRNG
            using var rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, salt, 100000);
            byte[] hash = rfc2898DeriveBytes.GetBytes(32);
            //Combine the salt and password bytes for later use
            byte[] hashBytes = new byte[48];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 32);
            //Turn the combined salt+hash into a string for storage
            string savedPasswordHash = Convert.ToBase64String(hashBytes);
            return savedPasswordHash;
        }
        //Verify the user-entered password against a stored password
        public bool VerifyPassword(string password, string storedPasswordHash)
        {
            //extract bytes
            byte[] hashBytes = Convert.FromBase64String(storedPasswordHash);
            //get salt
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);
            //compute the hash on password the user entered
            using var rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, salt, 100000);
            byte[] hash = rfc2898DeriveBytes.GetBytes(32);

            //compare results
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
            throw new Exception("Invalid login credentials");
            
        }
        public bool IsUserInputValid(string userName, string password)
        {
            //kijkt of username of wachtwoord null is, empty is of alleen maar lege karakters heeft
            return !string.IsNullOrWhiteSpace(userName) || !string.IsNullOrWhiteSpace(password);
        }
    }
}
