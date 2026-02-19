//using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment_1
{
    public class taskDatabase
    {
     //   public static string connectionString = "Server=localhost;Database=taskmanager;Trusted_Connection=True;Encrypt=False;";
     private readonly string connectionString;
        public taskDatabase(string _connectionString)
        {
            connectionString = _connectionString;
        }

        public  DataTable getTasks(string employee_id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlDataAdapter da = new SqlDataAdapter("GetTasks", connection);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                da.SelectCommand.Parameters.AddWithValue("@employeeId", employee_id);

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;

            }
        }
       

        public  void addTasks(string employee_id, string task_discription, bool task_status)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand command = new SqlCommand("addTasks", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@empId", employee_id);
                command.Parameters.AddWithValue("@taskDiscription", task_discription);
                command.Parameters.AddWithValue("@taskStatus", task_status ? 1 : 0);

                connection.Open();
                command.ExecuteNonQuery();
            }

        }

        public  void editTask(int task_id, string task_discription, bool task_status)
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
        public  void deleteTask(int task_id)
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

        public  DataTable getTaskById(int taskId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("GetTaskById", connection);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                da.SelectCommand.Parameters.AddWithValue("@taskId", taskId);

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }
    } }
    


