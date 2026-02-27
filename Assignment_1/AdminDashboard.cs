using Assignment_1.Modals;
using Assignment_1.Services;
using Microsoft.EntityFrameworkCore.Metadata;
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
    public partial class AdminDashboard : Form
    {

        private string employeeId = null;
        private readonly EmployeeServices _employeeServices;
        private readonly EmployeeTaskService _taskServices;
        private readonly Form _loginform;
        public AdminDashboard(EmployeeServices employeeServices, EmployeeTaskService taskServices, Form loginForm)
       
        {
            InitializeComponent();
           _loginform = loginForm;
            _employeeServices = employeeServices;
            _taskServices = taskServices;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;

            //Using List//

            //dataGridView1.Columns["EmployeeId"].DataPropertyName = "EmployeeId";
            //dataGridView1.Columns["EmployeeName"].DataPropertyName = "EmployeeName";
            //dataGridView1.DataSource = User.userlist;

            //Using Database//

            dataGridView1.AutoGenerateColumns = false;
            var employee = await _employeeServices.GetEmployee();
            dataGridView1.DataSource = employee;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            show_tasks.Visible = true;

        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            //Using List//

            //dataGridView2.Columns["EmpId"].DataPropertyName = "employee_id";
            //dataGridView2.Columns["TaskId"].DataPropertyName = "task_id";
            //dataGridView2.Columns["TaskDiscription"].DataPropertyName = "task_discription";
            //dataGridView2.Columns["TaskStatus"].DataPropertyName = "task_status";

            //Using List and Database//
            show_tasks.Visible = false;
            dataGridView2.AutoGenerateColumns = false;
            BackButton.Visible = false;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            Status.Visible = false;
            //  StatusLabel.Visible = false;
        }

        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(employeeId))
                return;

            string selected_action = Status.Text;

            List<Assignment_1.Modals.Task> tasks =
                await _taskServices.getTasks(employeeId);

            List<Assignment_1.Modals.Task> filtered;

            if (selected_action == "All")
            {
                filtered = tasks;
            }
            else if (selected_action == "Pending")
            {
                filtered = tasks.Where(t => !t.TaskStatus).ToList();
            }
            else if (selected_action == "Completed")
            {
                filtered = tasks.Where(t => t.TaskStatus).ToList();
            }
            else
            {
                filtered = new List<Assignment_1.Modals.Task>();
            }

            dataGridView2.DataSource = filtered;

            //Using Database//


            //try
            //{
            //    var employeeTask = await _taskServices.ToggleStatus(employeeId, selected_action);
            //    if (employeeTask != null)
            //    {
            //        dataGridView2.DataSource = employeeTask;
            //    }
            //    else
            //    {
            //        dataGridView2.DataSource = null;
            //        MessageBox.Show("No tasks found");

            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error Occured : " + ex.Message);
            //}

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            BackButton.Visible = false;
            Status.Visible = false;
            show_tasks.Visible = false;
            ViewEmployees.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            _loginform.Show();
            this.Close();
            
        }

        private async void show_tasks_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                //Using List//

                //string employeeid = selectedUser.EmployeeId;
                //var filterTasks = Task_Store.tasks.Where(t => t.employee_id == employeeid).ToList();

                //dataGridView2.AutoGenerateColumns = false;
                //dataGridView2.DataSource = filterTasks;
                //StatusLabel.Visible = true;
                //Status.Visible = true;
                //dataGridView2.Visible = true;
                //BackButton.Visible = true;


                //Using Database//
                var selectedEmployee = (Employee)dataGridView1.CurrentRow.DataBoundItem;
                employeeId = selectedEmployee.EmployeeId;   // test value

                var dt =await _taskServices.getTasks(employeeId);
                dataGridView2.DataSource = dt;
                dataGridView2.AutoGenerateColumns = false;
                ViewEmployees.Visible = false;
                Status.Visible = true;
                dataGridView2.Visible = true;
                dataGridView1.Visible = false;
                BackButton.Visible = true;

            }
            else
            {
                MessageBox.Show("No user found");
            }
        }
    }
}
