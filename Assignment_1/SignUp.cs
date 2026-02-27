using Assignment_1.Services;
using Microsoft.Identity.Client;
using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment_1.Modals;

namespace Assignment_1
{
    public partial class SignUp : Form
    {
        private readonly EmployeeServices _employeeServices;
        private readonly EmployeeTaskService _employeeTaskService;
        public SignUp(EmployeeServices employeeServices, EmployeeTaskService employeeTaskService)
        {
            InitializeComponent();
            _employeeServices = employeeServices;
            _employeeTaskService = employeeTaskService;
        }

      

        private async void createAccount_Click(object sender, EventArgs e)
        {
            var exist = await _employeeServices.isEmployee(employeeId.Text);
            if (exist)
            {
                var user = new Employee
                {
                    EmployeeId = employeeId.Text,
                    EmployeeName = employee_name.Text,
                    Password= employee_password.Text,
                    Role=roleBox.Text
                };
                _employeeServices.addUer(user);
                Login login = new Login(_employeeServices, _employeeTaskService);
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
