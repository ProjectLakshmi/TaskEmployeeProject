using Microsoft.Data.SqlClient;
using System.Data;

namespace Assignment_1
{
    public partial class Login : Form
    {
        // private static string connStr = "Server=localhost;Database=taskmanager;Trusted_Connection=True;Encrypt=False;";
        private readonly taskDatabase taskDatabase;
        private readonly userDatabase userDatabase;
        public Login(userDatabase _userDatabase,taskDatabase _taskDatabase)
        {
            InitializeComponent();
            this.userDatabase = _userDatabase;
            this.taskDatabase = _taskDatabase;
        }




        private void LginButton1_Click(object sender, EventArgs e)
        {
            string employeeId = Username.Text.Trim();
            string password = password_text.Text.Trim();
            string role = roleBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(employeeId) ||
        string.IsNullOrWhiteSpace(password) ||
        string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Please fill all fields",
                    "Login Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            try
            {
object result = userDatabase.LoginValidation(employeeId, password, role);
                if(result==null)
                {
                    MessageBox.Show("Invalid credentials",
                "Login Failed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                    return;
                }
                if (role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                {
                    AdminDashboard admin = new AdminDashboard(userDatabase,taskDatabase,this);
                   
                    admin.Show();
                    //this.Hide();
                }
                else if (role.Equals("Employee", StringComparison.OrdinalIgnoreCase))
                {
                    EmployeeDashboard employee =new EmployeeDashboard(taskDatabase, employeeId,this);
                  
                    employee.Show();
                   // this.Hide();


                }
            }
            catch (Exception ex) {
                MessageBox.Show("Something went wrong: " + ex.Message,
           "System Error",
           MessageBoxButtons.OK,
           MessageBoxIcon.Error);
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
            Forget_Password forget_Password = new Forget_Password(userDatabase);
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
            SignUp sign = new SignUp(userDatabase,taskDatabase);
            sign.Show();
        }

   
    }
}
