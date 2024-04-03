using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account
    {
        public string UserId { get; set; }
        public string Password { get; set; }
        public string EmployeeId { get; set; }
        public string Level { get; set; } // Phân quyền

        public Account(string userId, string password, string employeeId)
        {
            UserId = userId;
            Password = password;
            EmployeeId = employeeId;
        }

        public Account(string userId, string password, string employeeId, string level)
        {
            UserId = userId;
            Password = password;
            EmployeeId = employeeId;
            Level = level;
        }

    }
}
