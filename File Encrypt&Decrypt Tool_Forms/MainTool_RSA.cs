using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Encrypt_Decrypt_Tool_Forms
{
    public partial class MainTool_RSA : Form
    {
        private RSACryptoServiceProvider? rsa;

        public MainTool_RSA()
        {
            InitializeComponent();
            InitializeRSA();
        }

        private void InitializeRSA()
        {
            rsa = new RSACryptoServiceProvider(2048);
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    TxtFilePath.Text = ofd.FileName;
                }
            }
        }

        private void BtnEncrypt_Click(object sender, EventArgs e)
        {
            string filePath = TxtFilePath.Text;
            if (File.Exists(filePath))
            {
                try
                {
                    string plainText = File.ReadAllText(filePath);
                    string encryptedText = Encrypt(plainText);
                    File.WriteAllText(filePath + ".enc", encryptedText);
                    MessageBox.Show("File encrypted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred during encryption: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a valid file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDecrypt_Click(object sender, EventArgs e)
        {
            string filePath = TxtFilePath.Text;
            if (File.Exists(filePath))
            {
                try
                {
                    string encryptedText = File.ReadAllText(filePath);
                    string decryptedText = Decrypt(encryptedText);
                    File.WriteAllText(filePath.Replace(".enc", ".dec"), decryptedText);
                    MessageBox.Show("File decrypted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred during decryption: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a valid file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Close_pb_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Return_pb_Click(object sender, EventArgs e)
        {
            ToolMainMenu toolMainMenu = new ToolMainMenu();
            toolMainMenu.Show();
            this.Hide();
        }

        private string Encrypt(string plainText)
        {
            byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
            byte[] cipherBytes = rsa.Encrypt(plainBytes, false);
            return Convert.ToBase64String(cipherBytes);
        }

        private string Decrypt(string encryptedText)
        {
            byte[] cipherBytes = Convert.FromBase64String(encryptedText);
            byte[] plainBytes = rsa.Decrypt(cipherBytes, false);
            return Encoding.UTF8.GetString(plainBytes);
        }
    }
}
