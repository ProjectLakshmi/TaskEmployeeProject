using Assignment_1.Modals;
using Assignment_1.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment_1
{

    public partial class Employee_Task_Add : Form
    {

        private string employeeId;
        private readonly EmployeeTaskService _employeeTaskServices;
        public Employee_Task_Add(EmployeeTaskService employeeTaskService, string emp_id)
        {
            InitializeComponent();
            _employeeTaskServices = employeeTaskService;
            employeeId = emp_id;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //using table//

            //int id = Task_Store.tasks.Count + 1;

            string taskDiscription = textBox2.Text;
            bool taskStatus = (status_box.Text == "Completed") ? true : false;


            //Task_Store.tasks.Add(new Task_Class(employeeId, id, taskDiscription, taskStatus));

            // using database//
            if (string.IsNullOrWhiteSpace(taskDiscription))
            {
                MessageBox.Show("Please enter task description");
                return;
            }
            try
            {
                var task = new Assignment_1.Modals.Task
                {
                    EmployeeId = employeeId,
                    TaskDiscrption = taskDiscription,
                    TaskStatus = taskStatus
                };

                await _employeeTaskServices.addTasks(task);
                //string description = textBox2.Text;

                //string[] lines = description.Split(
                //    new[] { Environment.NewLine },
                //    StringSplitOptions.RemoveEmptyEntries);

                //foreach (string line in lines)
                //{
                //    _taskDatabase.addTasks(employeeId, line, false);
                //}

                // Reload grid after insert
                //dataGridView1.DataSource = _taskDatabase.getTasks(employeeId);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding task: " + ex.Message);
            }

            //  this.Close();

        }

        private void Employee_Task_Add_Load(object sender, EventArgs e)
        {
            employee_Id.Text = employeeId;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox2, textBox2.Text);
        }
    }
}
