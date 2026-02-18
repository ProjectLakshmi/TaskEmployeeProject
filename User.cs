 using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    internal class User
    {
      public  string EmployeeId { get; set; }
      public  string EmployeeName { get; set; }

        public User(string employeeId, string employeeName)
        {
            EmployeeId = employeeId;
            EmployeeName = employeeName;
        }
        public static List<User> userlist = new List<User>{new User("employee1","Javis"),new User("employee2","Mark")};
    }
}
