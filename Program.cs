namespace Assignment_1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        private static taskDatabase taskDatabase;
        private static userDatabase userDatabase;
        private static DBManager dBManager;

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            string connectionString = "Server=localhost;Database=taskmanager;Trusted_Connection=True;Encrypt=False;";
            dBManager = new DBManager(connectionString);
            taskDatabase=new taskDatabase(dBManager);
            userDatabase=new userDatabase(dBManager);

            ApplicationConfiguration.Initialize();
            Application.Run(new Login(userDatabase,taskDatabase));
            
        }
    }
}