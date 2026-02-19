using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Assignment_1
{
    public partial class EmployeeTaskEdit : Form
    {
        private readonly taskDatabase _taskDatabase;
        private int task_id;

        public EmployeeTaskEdit(taskDatabase _taskdatabase,int taskId)
        {

            InitializeComponent();
            _taskDatabase = _taskdatabase;
            task_id = taskId;
           

            //UpdatedTextDiscription.Text = selectedtask.task_discription;
            //UpdatedTaskStatus.Text = (selectedtask.task_status) ? "Completed" : "Not Completed";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UpdatedTextDiscription.Text))
            {
                MessageBox.Show("Please enter Task Discription");
                return;
            }
            //Using List//

            //selectedtask.task_discription = UpdatedTextDiscription.Text;
            //selectedtask.task_status = (UpdatedTaskStatus.Text=="Completed")?true:false;

            //Using Database//
            try
            {
                string taskDiscription = UpdatedTextDiscription.Text;
                bool taskStatus;

                if (UpdatedTaskStatus.Text.Trim().Equals("Completed", StringComparison.OrdinalIgnoreCase))
                {
                    taskStatus = true;
                }
                else
                {
                    taskStatus = false;
                }

                _taskDatabase.editTask(task_id, taskDiscription, taskStatus);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred here: " + ex.Message);
            }



            this.Close();

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmployeeTaskEdit_Load(object sender, EventArgs e)
        {
            DataTable dt = _taskDatabase.getTaskById(task_id);

            if (dt.Rows.Count > 0)
            {
                UpdatedTextDiscription.Text =
                    dt.Rows[0]["task_discrption"].ToString();

                bool status =
                    Convert.ToBoolean(dt.Rows[0]["task_status"]);

                UpdatedTaskStatus.Text =
                    status ? "Completed" : "Not Completed";
            }
        }
    }
}
