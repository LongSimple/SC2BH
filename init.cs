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
            tankbattle tb_instance = new tankbattle();
            string Bank_Code_Test =
                "TWVFbNu0CRBOgVKikAaLR6wgZh2BgCLEpwWz3njGCotpOy8bk0GFJt6TqKEY0V9JEBfZ75YgQ9oRHW8nBllz";
            string Player_Handle_Test = "1-S2-2466377";
            string decrypted = tb_instance.gf_Bank_Decrypt(Bank_Code_Test, Player_Handle_Test);
            string encrypted = tb_instance.gf_Bank_Encrypt(decrypted, Player_Handle_Test);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainform());
            
        }
    }
}
