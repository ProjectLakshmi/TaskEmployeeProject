using Assignment_1.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Assignment_1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        //private static taskDatabase taskDatabase;
        //private static userDatabase userDatabase;
        //private static DBManager dBManager;

        private static EmployeeServices employeeServices;
        private static EmployeeTaskService taskService;

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            string connectionString = "Server=localhost;Database=taskmanager;Trusted_Connection=True;Encrypt=False;";
            //dBManager = new DBManager(connectionString);
            //taskDatabase=new taskDatabase(dBManager);
            //userDatabase=new userDatabase(dBManager);
            var services = new ServiceCollection();

            services.AddHttpClient<EmployeeServices>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:7165/");
            });
            services.AddHttpClient<EmployeeTaskService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:7165/");
            });

            services.AddTransient<Login>();
            services.AddTransient<EmployeeDashboard>();
            services.AddTransient<AdminDashboard>();
            services.AddTransient<Forget_Password>();
            services.AddTransient<SignUp>();
            services.AddTransient<Employee_Task_Add>();
            services.AddTransient<EmployeeTaskEdit>();

            var serviceProvider = services.BuildServiceProvider();
            var loginForm = serviceProvider.GetRequiredService<Login>();

            Application.Run(loginForm);
            
        }
    }
}