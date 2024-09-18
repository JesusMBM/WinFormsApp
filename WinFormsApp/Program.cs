using System;
using System.Windows.Forms;

namespace WinFormsApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Enable visual styles and set text rendering defaults for .NET Framework 4.8.1
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Run the main form (replace 'Login' with your main form's name)
            Application.Run(new Login());
        }
    }
}
