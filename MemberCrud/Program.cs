namespace MemberCrud
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
        // Ensure seed data is present (inserts sample rows if tables are empty)
        MemberCrud.Data.DbSeeder.Seed();

        Application.Run(new ChurchManagement());
        }
    }
}