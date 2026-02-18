using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Assignment_1
{

    public partial class Employee_Task_Add : Form
    {

        private string employeeId;
        public Employee_Task_Add(string emp_id)
        {
            InitializeComponent();
            employeeId = emp_id;
        }

        private void button1_Click(object sender, EventArgs e)
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
                int taskId = taskDatabase.GetNextTaskId();
                taskDatabase.addTasks(employeeId, taskId, taskDiscription, taskStatus);
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
    }
}
