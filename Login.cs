using Microsoft.Data.SqlClient;
using System.Data;

namespace Assignment_1
{
    public partial class Login : Form
    {
        private static string connStr = "Server=localhost;Database=taskmanager;Trusted_Connection=True;Encrypt=False;";
        public Login()
        {
            InitializeComponent();
        }




        private void LginButton1_Click(object sender, EventArgs e)
        {
            string employeeId = Username.Text.Trim();
            string password = password_text.Text.Trim();
            string role = roleBox.Text.Trim();

            using (SqlConnection con = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand("LoginChecking", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@empId", employeeId);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@role", role);

                    con.Open();

                    object result = cmd.ExecuteScalar();

                    if (result == null)
                    {
                        MessageBox.Show("Invalid credentials");
                        return;
                    }

                    // Login Success
                    if (role == "Admin")
                    {
                        AdminDashboard admin = new AdminDashboard();
                        admin.Show();
                    }
                    else if (role == "Employee")
                    {
                        EmployeeDashboard employee = new EmployeeDashboard(result.ToString());
                        employee.Show();
                    }
                }
            }
        }




        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            password_text.UseSystemPasswordChar = !password_text.UseSystemPasswordChar;
        }

        private void forget_password_MouseEnter(object sender, EventArgs e)
        {
            forget_password.ForeColor = Color.Blue;
        }

        private void forget_password_Click(object sender, EventArgs e)
        {
            Forget_Password forget_Password = new Forget_Password();
            forget_Password.Show();
        }

        private void Username_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(Username.Text))
            //{
            //    e.Cancel = true;
            //    errorProvider1.SetError(Username, "Username is required");
            //}
            //else
            //{
            //    e.Cancel = false;
            //    errorProvider1.Clear();
            //}
        }
        private void sign_up_label_MouseEnter(object sender, EventArgs e)
        {
            sign_up_label.ForeColor = Color.Blue;
        }

        private void sign_up_label_Click(object sender, EventArgs e)
        {
            SignUp sign = new SignUp();
            sign.Show();
        }

   
    }
}
