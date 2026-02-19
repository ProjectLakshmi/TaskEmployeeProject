using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Assignment_1
{
    public partial class EmployeeDashboard : Form
    {
        private string employee_Id;
        private readonly taskDatabase _taskDatabase;
        private readonly Form _loginForm;

        public EmployeeDashboard(taskDatabase taskdatabase, string employeeId, Form loginForm)
        {

            InitializeComponent();
            _taskDatabase = taskdatabase;
            employee_Id = employeeId;
            _loginForm = loginForm;
        }

        private void EmployeeDashboard_Load(object sender, EventArgs e)

        {

            //dataGridView1.Columns["TaskId"].DataPropertyName = "task_id";
            //dataGridView1.Columns["TaskDiscription"].DataPropertyName = "task_discription";
            //dataGridView1.Columns["TaskStatus"].DataPropertyName = "task_status";

            //     var selectedemp=Task_Store.tasks.Where(t=>t.employee_id==employee_Id).ToList();



            edit_task.Visible = false;
            delete_Task.Visible = false;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataTable tasksData = _taskDatabase.getTasks(employee_Id);


            dataGridView1.DataSource = tasksData;


            // dataGridView1.DataSource = selectedemp;




            ToggleEditColumnVisibility();

            //Task_Store.tasks.ListChanged += (s, ev) => ToggleEditColumnVisibility();



        }

        private void ToggleEditColumnVisibility()
        {

            //dataGridView1.Columns["Edit"].Visible = Task_Store.tasks.Count > 0;

            //if (Task_Store.tasks.Count > 0)
            //{
            //    dataGridView1.Columns["Edit"].Visible = true;
            //}

            //if (Task_Store.tasks.Count > 0)
            //{
            //    dataGridView1.Columns["DeleteTask"].Visible = true;
            //}

        }



        private void Add_Click(object sender, EventArgs e)
        {
            Employee_Task_Add employee_Task_Add = new Employee_Task_Add(_taskDatabase, employee_Id);
            employee_Task_Add.ShowDialog();


            //Using List//
            //   dataGridView1.DataSource = Task_Store.tasks.Where(t => t.employee_id == employee_Id).ToList();


            //Using database//
            try
            {
                DataTable tasksData = _taskDatabase.getTasks(employee_Id);
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 0) return;

            DataRowView row = (DataRowView)dataGridView1.CurrentRow.DataBoundItem;
            int taskId = Convert.ToInt32(row["task_id"]);


            EmployeeTaskEdit taskedit = new EmployeeTaskEdit(_taskDatabase, taskId);
            taskedit.ShowDialog();

            //Using List//

            //Task_Class selectedTask = (Task_Class)dataGridView1.Rows[e.RowIndex].DataBoundItem;
            //EmployeeTaskEdit taskEdit = new EmployeeTaskEdit(selectedTask);
            //taskEdit.ShowDialog();

            //Using database//
            try
            {
                DataTable tasksData = _taskDatabase.getTasks(employee_Id);
                dataGridView1.DataSource = tasksData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured :" + ex.Message);
            }


            dataGridView1.Refresh();
        }



        private void delete_Task_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)dataGridView1.CurrentRow.DataBoundItem;
            int taskId = Convert.ToInt32(row["task_id"]);


            //Task_Class taskdelete = (Task_Class)dataGridView1.Rows[e.RowIndex].DataBoundItem;

            string taskDescription = row["task_discrption"].ToString();

            // var confirm = MessageBox.Show($"Are you sure to delete the '{taskDescription}'?", "Confirm Delete", MessageBoxButtons.YesNo);
            var confirm = MessageBox.Show($"Are you sure you want to delete \"{taskDescription}\"?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (confirm == DialogResult.Yes)
            {
                //Task_Store.tasks.Remove(taskdelete);
                //var filtered = Task_Store.tasks.Where(t=>t.employee_id== taskdelete.employee_id).ToList();
                //dataGridView1.DataSource = filtered;
                _taskDatabase.deleteTask(taskId);
                DataTable filtered = _taskDatabase.getTasks(employee_Id);
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
