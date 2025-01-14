using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Healthcare_Management_System.Forms.Login_and_Sign_Up;

namespace Healthcare_Management_System
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // MessageBox.Show($"Current directory: {DataStore.testDir}", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Signup signup = new Signup();
            Application.Run(new Login());
            // Application.Run(new Form1());
        }
    }

}
