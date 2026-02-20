
using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Text;

namespace Assignment_1
{
    public class userDatabase
    {
 
      private readonly DBManager dBManager;
        public userDatabase(DBManager  _dBManager)
        {
            dBManager = _dBManager;
        }


        public  DataTable getEmployee()
        {
            return dBManager.ExecuteQuery("GetEmployee");
        }

        public  DataTable toggleStatus(string employee_id, string status)
        {
            return dBManager.ExecuteQuery("ToggleStatus", new SqlParameter[]
            {
               new SqlParameter("@employeeId",employee_id),
               new SqlParameter("@status",status)
            });
        }

        public  bool isEmployee(string employee_id)
        {
            return dBManager.ExecuteBool("IsEmployee", new SqlParameter[]
            {
               new SqlParameter("@empId",employee_id)
            });

        }

        public  void UpdatePassword(string employeeId,string newPassword)
        {
            dBManager.ExecuteNonQuery("UpdatePassword", new SqlParameter[]
            {
               new SqlParameter("@empId",employeeId),
               new SqlParameter("@password",newPassword)
            });
        }


        public  void addUser(string employeeName,string employeeID, string password,string role)
        {
            dBManager.ExecuteNonQuery("addUser", new SqlParameter[]
            {
               new SqlParameter("@employeeID",employeeID),
               new SqlParameter("@employeeName",employeeName),
               new SqlParameter("@employeePassword",password),
               new SqlParameter("@role",role)
            });
        }

        public object LoginValidation(string employeeId, string password, string role)
        {
            return dBManager.ExecuteScalar("LoginChecking", new SqlParameter[]
            {
               new SqlParameter("@empId",employeeId),
               new SqlParameter("@password",password),
               new SqlParameter("@role",role)
            });
        }
    }
}

