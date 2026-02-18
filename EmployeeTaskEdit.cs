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

        private int task_id;

        public EmployeeTaskEdit(int taskId)
        {

            InitializeComponent();
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

                taskDatabase.editTask(task_id, taskDiscription, taskStatus);

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
