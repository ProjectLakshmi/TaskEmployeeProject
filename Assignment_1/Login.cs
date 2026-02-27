using Assignment_1.DTO;
using Assignment_1.Services;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;

namespace Assignment_1
{
    public partial class Login : Form
    {
        // private static string connStr = "Server=localhost;Database=taskmanager;Trusted_Connection=True;Encrypt=False;";
        private readonly EmployeeServices _employeeServices;
        private readonly EmployeeTaskService _employeetaskServices;
        public Login(EmployeeServices employeeService, EmployeeTaskService employeeTaskService)
        {
            InitializeComponent();
            _employeeServices = employeeService;
            _employeetaskServices = employeeTaskService;
        }




        private async void LginButton1_Click(object sender, EventArgs e)
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
                var loginDto = new LoginDto
                {
                    EmployeeId = employeeId,
                    Password = password,
                    Role = role
                };
                var result = await _employeeServices.LoginValidation(loginDto);
                if (result == null)
                {
                    MessageBox.Show("Invalid credentials",
                "Login Failed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                    Username.Text = "";
                    password_text.Text = "";
                    roleBox.SelectedIndex = -1;
                    return;
                }
                if (role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                {
                    AdminDashboard admin = new AdminDashboard(_employeeServices, _employeetaskServices, this);

                    admin.Show();
                    //this.Hide();
                }
                else if (role.Equals("Employee", StringComparison.OrdinalIgnoreCase))
                {
                    EmployeeDashboard employee = new EmployeeDashboard(_employeetaskServices, employeeId, this);

                    employee.Show();
                    // this.Hide();


                }
                Username.Text = "";
                password_text.Text = "";
                roleBox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex.Message,
           "System Error",
           MessageBoxButtons.OK,
           MessageBoxIcon.Error);
            }


        }




        //private void checkBox1_CheckedChanged(object sender, EventArgs e)
        //{
        //    password_text.UseSystemPasswordChar = !password_text.UseSystemPasswordChar;
        //}

        private void forget_password_MouseEnter(object sender, EventArgs e)
        {
            forget_password.ForeColor = Color.Blue;
        }

        private void forget_password_Click(object sender, EventArgs e)
        {
            Forget_Password forget_Password = new Forget_Password(_employeeServices);
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
            SignUp sign = new SignUp(_employeeServices, _employeetaskServices);
            sign.Show();
        }

        private void forget_password_MouseLeave(object sender, EventArgs e)
        {
            forget_password.ForeColor = Color.Black;
        }

        private void sign_up_label_MouseLeave(object sender, EventArgs e)
        {
            sign_up_label.ForeColor = Color.Black;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            password_text.UseSystemPasswordChar = !password_text.UseSystemPasswordChar;
        }
    }
}
