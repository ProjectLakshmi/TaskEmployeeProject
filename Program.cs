namespace Assignment_1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        private static taskDatabase taskDatabase;
        private static userDatabase userDatabase;
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            string connectionString = "Server=localhost;Database=taskmanager;Trusted_Connection=True;Encrypt=False;";
            taskDatabase=new taskDatabase(connectionString);
            userDatabase=new userDatabase(connectionString);
            ApplicationConfiguration.Initialize();
            Application.Run(new Login(userDatabase,taskDatabase));
            
        }
    }
}