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
        public SignUp()
        {
            InitializeComponent();
        }

      

        private void createAccount_Click(object sender, EventArgs e)
        {
            if (!userDatabase.isEmployee(employeeId.Text))
            {
                userDatabase.addUser(employee_name.Text, employeeId.Text, employee_password.Text,roleBox.Text);
                Login login = new Login();
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
