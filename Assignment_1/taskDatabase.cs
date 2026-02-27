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
     private readonly DBManager dbManager;
        public taskDatabase(DBManager _dbmanager)
        {
            dbManager = _dbmanager;
        }

        public  DataTable getTasks(string employee_id)
        {
            return dbManager.ExecuteQuery("GetTasks", new SqlParameter[]{
                new SqlParameter("@employeeId", employee_id)
            });
        }
       

        public  void addTasks(string employee_id, string task_discription, bool task_status)
        {
            dbManager.ExecuteNonQuery("AddTasks", new SqlParameter[]
            {
               new SqlParameter("@empId",employee_id),
               new SqlParameter("@taskDiscription",task_discription),
               new SqlParameter("@taskStatus", task_status ? 1 : 0)
            });

        }

        public  void editTask(int task_id, string task_discription, bool task_status)
        {
            dbManager.ExecuteNonQuery("EditTask", new SqlParameter[]
            {
              new SqlParameter("@taskId",task_id),
              new SqlParameter("@taskDiscription",task_discription),
              new SqlParameter("@taskStatus",task_status)
            });
        }
        public  void deleteTask(int task_id)
        {
            dbManager.ExecuteNonQuery("DeleteTask", new SqlParameter[]
            {
                new SqlParameter("@taskId",task_id)
            });
        }

        public  DataTable getTaskById(int taskId)
        {
            return dbManager.ExecuteQuery("GetTaskById", new SqlParameter[]
            {
               new SqlParameter("@taskId",taskId)
            });
        }
    } }
    


