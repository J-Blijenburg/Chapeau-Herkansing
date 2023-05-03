using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int EmployeeNumber { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public DateTime RegistrationDate { get; set; }
        public EmployeeRole Role { get; set; }
    }
}
