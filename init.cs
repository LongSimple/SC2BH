using System;
using System.Linq;
using System.Windows.Forms;
using BankHacks.Libraries;

namespace BankHacks
{
    static class init
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainform());
            
        }
    }
}
