using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Encrypt_Decrypt_Tool_Forms
{
    public partial class ToolMainMenu : Form
    {
        public ToolMainMenu()
        {
            InitializeComponent();
        }

        private void Close_pb_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AES_btn_Click(object sender, EventArgs e)
        {
            FileEncrypt_Decrypt fileEncrypt_Decrypt = new FileEncrypt_Decrypt();
            fileEncrypt_Decrypt.Show();
            this.Hide();
        }

        private void About_lbl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("File Encrypt&Decrypt Tool\n\n\nCreated by: SoulReaper96\nVersion: 1.0", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DES_btn_Click(object sender, EventArgs e)
        {
            MainTool_DES mainTool_DES = new MainTool_DES();
            mainTool_DES.Show();
            this.Hide();
        }

        private void TripleDES_btn_Click(object sender, EventArgs e)
        {
            MainTool_TripleDES mainTool_TripleDES = new MainTool_TripleDES();
            mainTool_TripleDES.Show();
            this.Hide();
        }
    }
}
