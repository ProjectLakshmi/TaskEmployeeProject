using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Assignment_1
{
    public partial class Forget_Password : Form
    {
        private readonly userDatabase userDatabase;
        public Forget_Password(userDatabase _userdatabase)
        {
            InitializeComponent();
            this.userDatabase = _userdatabase;
        }

       

        private void Forget_Password_Load(object sender, EventArgs e)
        {
            new_pasword.Visible = false;
            confirm_password.Visible = false;
            newPasswordText.Visible = false;
            confirmPasswordtext.Visible = false;
            update_password.Visible = false;
            verify_user.Enabled = true;
            verify_user.Visible = true;
        }
        
        private void update_password_Click(object sender, EventArgs e)
        {
            if (newPasswordText.Text.Trim() == confirmPasswordtext.Text.Trim())
            {
                string employeeId = usernameText.Text.Trim();
                string password = newPasswordText.Text.Trim();
                string confirmPassword = confirmPasswordtext.Text.Trim();

                if (string.IsNullOrWhiteSpace(employeeId) ||
       string.IsNullOrWhiteSpace(password) ||
       string.IsNullOrWhiteSpace(confirmPassword))
                {
                    MessageBox.Show("Please fill all fields");
                    return;
                }
                if (password != confirmPassword)
                {
                    MessageBox.Show("Passwords do not match");
                    return;
                }

                if (userDatabase.isEmployee(employeeId))
                {
                    userDatabase.UpdatePassword(employeeId, password);
                    MessageBox.Show("Password is changed");
                }
                else
                {
                    MessageBox.Show("Username is invalid");
                }

                    this.Close();
            }
        }

      

        private void verify_user_Click_1(object sender, EventArgs e)
        {
            if (userDatabase.isEmployee(usernameText.Text.Trim()))
            {
                new_pasword.Visible = true;
                confirm_password.Visible = true;
                newPasswordText.Visible = true;
                confirmPasswordtext.Visible = true;
                update_password.Visible = true;

            }
            else
            {
                MessageBox.Show("Username is not correct");
            }
        }
    }
}
