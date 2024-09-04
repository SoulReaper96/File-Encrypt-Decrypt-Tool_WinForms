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
    public partial class MainTool_TripleDES : Form
    {
        private byte[]? tripdesKey;
        private byte[]? tripdesIV;

        public MainTool_TripleDES()
        {
            InitializeComponent();
        }

        private void GenerateKey_btn_Click(object sender, EventArgs e)
        {
            GenerateTripleDESKey();
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
            if (string.IsNullOrEmpty(TxtFilePath.Text) || string.IsNullOrEmpty(Key_txtBox.Text))
            {
                MessageBox.Show("Please provide both file path and password.");
                return;
            }

            try
            {

                byte[] encrypted = Encrypt(TxtFilePath.Text, tripdesKey, tripdesIV);
                File.WriteAllBytes(TxtFilePath.Text + ".enc", encrypted);
                MessageBox.Show("File encrypted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BtnDecrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtFilePath.Text) || string.IsNullOrEmpty(Key_txtBox.Text))
            {
                MessageBox.Show("Please select a file to decrypt.");
                return;
            }

            try
            {
                byte[] decrypted = Decrypt(TxtFilePath.Text, tripdesKey, tripdesIV);
                File.WriteAllBytes(TxtFilePath.Text.Replace(".enc", ".dec"), decrypted);
                MessageBox.Show("File decrypted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Return_pb_Click(object sender, EventArgs e)
        {
            ToolMainMenu toolMainMenu = new ToolMainMenu();
            toolMainMenu.Show();
            this.Hide();
        }

        private void Close_pb_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private byte[] Encrypt(string filePath, byte[] key, byte[] iv)
        {
            byte[] fileBytes = File.ReadAllBytes(filePath);
            using (TripleDESCryptoServiceProvider tripDesAlg = new TripleDESCryptoServiceProvider())
            {
                tripDesAlg.Key = key;
                tripDesAlg.IV = iv;

                ICryptoTransform encryptor = tripDesAlg.CreateEncryptor(tripDesAlg.Key, tripDesAlg.IV);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(fileBytes, 0, fileBytes.Length);
                        cryptoStream.FlushFinalBlock();
                        return memoryStream.ToArray();
                    }
                }
            }
        }

        private byte[] Decrypt(string filePath, byte[] key, byte[] iv)
        {
            byte[] fileBytes = File.ReadAllBytes(filePath);
            using (TripleDESCryptoServiceProvider tripDesAlg = new TripleDESCryptoServiceProvider())
            {
                tripDesAlg.Key = key;
                tripDesAlg.IV = iv;

                ICryptoTransform decryptor = tripDesAlg.CreateDecryptor(tripDesAlg.Key, tripDesAlg.IV);

                using (MemoryStream memoryStream = new MemoryStream(fileBytes))
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (MemoryStream memoryStream2 = new MemoryStream())
                        {
                            cryptoStream.CopyTo(memoryStream2);
                            return memoryStream2.ToArray();
                        }
                    }
                }
            }
        }

        private void GenerateTripleDESKey()
        {
            using (TripleDESCryptoServiceProvider desAlg = new TripleDESCryptoServiceProvider())
            {
                desAlg.GenerateKey();
                desAlg.GenerateIV();

                tripdesKey = desAlg.Key;
                tripdesIV = desAlg.IV;

                Key_txtBox.Text = Convert.ToBase64String(tripdesKey);
                IV_txtBox.Text = Convert.ToBase64String(tripdesIV);
            }
        }
    }
}
