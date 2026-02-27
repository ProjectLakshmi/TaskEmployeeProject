using Assignment_1.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1
{
    public partial class EmployeeTaskEdit : Form
    {
        private readonly EmployeeTaskService _employeeTaskService;
        private int task_id;

        public EmployeeTaskEdit(EmployeeTaskService employeeTaskService,int taskId)
        {

            InitializeComponent();
            _employeeTaskService = employeeTaskService;
            task_id = taskId;
           

            //UpdatedTextDiscription.Text = selectedtask.task_discription;
            //UpdatedTaskStatus.Text = (selectedtask.task_status) ? "Completed" : "Not Completed";
        }

        private async void button1_Click(object sender, EventArgs e)
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
                var task = new Assignment_1.Modals.Task
                {
                    TaskId = task_id,
                    TaskDiscrption = taskDiscription,
                    TaskStatus = taskStatus
                };
               await _employeeTaskService.editTask(task_id,task);

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

        private async void EmployeeTaskEdit_Load(object sender, EventArgs e)
        {
            var task =await _employeeTaskService.getTAskById(task_id);

            if (task!=null)
            {
                UpdatedTextDiscription.Text = task.TaskDiscrption;

                UpdatedTaskStatus.Text =
                    task.TaskStatus ? "Completed" : "Not Completed";
            }
        }
    }
}
