using System;
using System.Collections.Generic;
using System.Data;
//using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Text;
using System.Windows.Markup;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment_1
{
    internal class taskDatabase
    {
        public static string connectionString = "Server=localhost;Database=taskmanager;Trusted_Connection=True;Encrypt=False;";

        public static DataTable getTasks(string employee_id)
        {
            using(SqlConnection connection =  new SqlConnection(connectionString))
            {
               
                SqlDataAdapter da = new SqlDataAdapter("GetTasks", connection);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                da.SelectCommand.Parameters.AddWithValue("@employeeId", employee_id);

                DataTable dt = new DataTable();
                da.Fill(dt);   

                return dt;
               
            }
        }
        public static int GetNextTaskId()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ISNULL(MAX(task_id), 0) + 1 FROM tasks";

                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public static void addTasks(string employee_id, int task_id, string task_discription, bool task_status)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
               
                SqlCommand command = new SqlCommand("AddTasks", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@empId", employee_id);
                command.Parameters.AddWithValue("@taskId", task_id);
                command.Parameters.AddWithValue("@taskDiscription", task_discription);
                command.Parameters.AddWithValue("@taskStatus", task_status ? 1 : 0);

                connection.Open();
                command.ExecuteNonQuery();
            }

        }

        public static void editTask(int task_id, string task_discription, bool task_status)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
               

                SqlCommand command = new SqlCommand("EditTask", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@taskId", task_id);
                command.Parameters.AddWithValue("@taskDiscription", task_discription);
                command.Parameters.AddWithValue("@taskStatus", task_status);

                connection.Open();
                command.ExecuteNonQuery();

            }
        }
        public static void deleteTask(int task_id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
               
                SqlCommand command = new SqlCommand("DeleteTask", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@taskId", task_id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    } 

}
