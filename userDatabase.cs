
using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Text;

namespace Assignment_1
{
    public class userDatabase
    {
      //  public static string connectionString = "Server=localhost;Database=taskmanager;Trusted_Connection=True;Encrypt=False;";
      private readonly string connectionString;
        public userDatabase(string _connectionString)
        {
            connectionString = _connectionString;
        }
        public  DataTable getEmployee()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
              

                SqlDataAdapter adapter = new SqlDataAdapter("GetEmployee", connection);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable employee = new DataTable();
                adapter.Fill(employee);
                return employee;
            }
        }
        public  DataTable toggleStatus(string employee_id, string status)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                SqlDataAdapter adapter = new SqlDataAdapter("ToggleStatus", connection);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                adapter.SelectCommand.Parameters.AddWithValue("@employeeId", employee_id);
                adapter.SelectCommand.Parameters.AddWithValue("@status", status);
                DataTable taskEmployee = new DataTable();
                adapter.Fill(taskEmployee);
                return taskEmployee;

            }
        }
        public  bool isEmployee(string employee_id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                SqlCommand command = new SqlCommand("IsEmployee", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@empId", employee_id);

                connection.Open();
                int count = (int)command.ExecuteScalar();

                return count > 0;
            }

        }
        public  void UpdatePassword(string employeeId,string newPassword)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
               
                SqlCommand command = new SqlCommand("UpdatePasword", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@empId", employeeId);
                command.Parameters.AddWithValue("@password", newPassword);
                
                connection.Open();
                command.ExecuteNonQuery();

            }
        }

        public  void addUser(string employeeName,string employeeID, string password,string role)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                SqlCommand command = new SqlCommand("addUser", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@employeeID", employeeID);
                command.Parameters.AddWithValue("@employeeName", employeeName);
                command.Parameters.AddWithValue("@employeePassword", password);
                command.Parameters.AddWithValue("@role", role);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public object LoginValidation(string employeeId, string password, string role)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("LoginChecking", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@empId", employeeId);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@role", role);

                    con.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }
    }
}

