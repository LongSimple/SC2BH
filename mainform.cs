using System.Windows.Forms;
using BankHacks.Libraries;

namespace BankHacks
{
    public partial class mainform : Form
    {
        private tankbattle tb_instance = new tankbattle();
        private Starcode Starcode = new Starcode();
        string playerHandleform = "";
        string encbankcodeform = "";
        string decbankcodeform = "";
        public mainform()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, System.EventArgs e) //encrypt
        {
            playerHandleform = playerhandleinput.Text;
            decbankcodeform = decryptedbankcodeinput.Text;
            string encryptedbank = tb_instance.gf_Bank_Encrypt(decbankcodeform, playerHandleform);
            encryptedbankcodeinput.Text = encryptedbank;
        }

        private void Button1_Click(object sender, System.EventArgs e) //decrypt
        {
            playerHandleform = playerhandleinput.Text;
            encbankcodeform = encryptedbankcodeinput.Text;
            string decryptedbank = tb_instance.gf_Bank_Decrypt(encbankcodeform, playerHandleform);
            decryptedbankcodeinput.Text = decryptedbank;
        }
    }
}
