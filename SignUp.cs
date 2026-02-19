using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Assignment_1
{
    public partial class SignUp : Form
    {
        private readonly userDatabase userDatabase;
        private readonly taskDatabase taskDatabase;
        public SignUp(userDatabase _userdatabase,taskDatabase _taskdatabase)
        {
            InitializeComponent();
            userDatabase = _userdatabase;
            taskDatabase = _taskdatabase;
        }

      

        private void createAccount_Click(object sender, EventArgs e)
        {
            if (!userDatabase.isEmployee(employeeId.Text))
            {
                userDatabase.addUser(employee_name.Text, employeeId.Text, employee_password.Text,roleBox.Text);
                Login login = new Login(userDatabase,taskDatabase);
                login.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("User exist already");
            }
        }
    }
}
