using Assignment_1.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Assignment_1
{
    public partial class EmployeeDashboard : Form
    {
        private string employee_Id;
        private readonly EmployeeTaskService _employeeTaskService;
        private readonly Form _loginForm;

        public EmployeeDashboard(EmployeeTaskService employeeTaskService, string employeeId, Form loginForm)
        {

            InitializeComponent();
            _employeeTaskService = employeeTaskService;
            employee_Id = employeeId;
            _loginForm = loginForm;
        }

        private async void EmployeeDashboard_Load(object sender, EventArgs e)

        {

            //dataGridView1.Columns["TaskId"].DataPropertyName = "task_id";
            //dataGridView1.Columns["TaskDiscription"].DataPropertyName = "task_discription";
            //dataGridView1.Columns["TaskStatus"].DataPropertyName = "task_status";

            //     var selectedemp=Task_Store.tasks.Where(t=>t.employee_id==employee_Id).ToList();



            edit_task.Visible = false;
            delete_Task.Visible = false;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
           var tasksData = await _employeeTaskService.getTasks(employee_Id);


            dataGridView1.DataSource = tasksData;


            // dataGridView1.DataSource = selectedemp;


        }

       



        private async void Add_Click(object sender, EventArgs e)
        {
            Employee_Task_Add employee_Task_Add = new Employee_Task_Add(_employeeTaskService, employee_Id);
            employee_Task_Add.ShowDialog();


            //Using List//
            //   dataGridView1.DataSource = Task_Store.tasks.Where(t => t.employee_id == employee_Id).ToList();


            //Using database//
            try
            {
                var tasksData = await _employeeTaskService.getTasks(employee_Id);
                dataGridView1.DataSource = tasksData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured :" + ex.Message);
            }



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            edit_task.Visible = true;
            delete_Task.Visible = true;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 0) return;
            var selectedTask = (Assignment_1.Modals.Task)dataGridView1.CurrentRow.DataBoundItem;
            int taskId = selectedTask.TaskId;


            EmployeeTaskEdit taskedit = new EmployeeTaskEdit(_employeeTaskService, taskId);
            taskedit.ShowDialog();

            //Using List//

            //Task_Class selectedTask = (Task_Class)dataGridView1.Rows[e.RowIndex].DataBoundItem;
            //EmployeeTaskEdit taskEdit = new EmployeeTaskEdit(selectedTask);
            //taskEdit.ShowDialog();

            //Using database//
            try
            {
                var tasksData = await _employeeTaskService.getTasks(employee_Id);
                dataGridView1.DataSource = tasksData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured :" + ex.Message);
            }


            dataGridView1.Refresh();
        }



        private async void delete_Task_Click(object sender, EventArgs e)
        {
            var selectedTask = (Assignment_1.Modals.Task)
               dataGridView1.CurrentRow.DataBoundItem;

            int taskId = selectedTask.TaskId;


            //Task_Class taskdelete = (Task_Class)dataGridView1.Rows[e.RowIndex].DataBoundItem;

            string taskDescription = selectedTask.TaskDiscrption.ToString();

            // var confirm = MessageBox.Show($"Are you sure to delete the '{taskDescription}'?", "Confirm Delete", MessageBoxButtons.YesNo);
            var confirm = MessageBox.Show($"Are you sure you want to delete \"{taskDescription}\"?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (confirm == DialogResult.Yes)
            {
                //Task_Store.tasks.Remove(taskdelete);
                //var filtered = Task_Store.tasks.Where(t=>t.employee_id== taskdelete.employee_id).ToList();
                //dataGridView1.DataSource = filtered;
               await _employeeTaskService.deleteTask(taskId);
                var filtered =await _employeeTaskService.getTasks(employee_Id);
                dataGridView1.DataSource = filtered;

                dataGridView1.Refresh();



            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            _loginForm.Show();
            this.Close();
        }
    }
}
