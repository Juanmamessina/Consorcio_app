namespace AppConsorcio
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
            
            FormLogIn formLogIn = new FormLogIn();
            formLogIn.Show();
            Application.Run();
            
        }
    }
}