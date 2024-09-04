using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace File_Encrypt_Decrypt_Tool_Forms
{
    public partial class FileEncrypt_Decrypt : Form
    {
        private byte[]? aesKey;
        private byte[]? aesIV;

        public FileEncrypt_Decrypt()
        {
            InitializeComponent();
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

        private void GenerateKey_btn_Click(object sender, EventArgs e)
        {
            GenerateAESKey();
        }

        private void BtnEncrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtFilePath.Text) || string.IsNullOrEmpty(Key_txtBox.Text))
            {
                MessageBox.Show("Please provide both file path and password.");
                return;
            }

            if (aesKey == null || aesIV == null)
            {
                MessageBox.Show("Please generate the key and IV first.");
                return;
            }

            try
            {
                byte[] encrypted = Encrypt(TxtFilePath.Text, aesKey, aesIV);
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

            if (aesKey == null || aesIV == null)
            {
                MessageBox.Show("Please generate the key and IV first.");
                return;
            }

            try
            {
                byte[] decrypted = Decrypt(TxtFilePath.Text, aesKey, aesIV);
                File.WriteAllBytes(TxtFilePath.Text.Replace(".enc", ".dec"), decrypted);
                MessageBox.Show("File decrypted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private byte[] Encrypt(string filePath, byte[] key, byte[] iv)
        {
            byte[] fileBytes = File.ReadAllBytes(filePath);
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

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
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

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

        private void GenerateAESKey()
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.GenerateKey();
                aesAlg.GenerateIV();

                aesKey = aesAlg.Key;
                aesIV = aesAlg.IV;

                Key_txtBox.Text = Convert.ToBase64String(aesKey);
                IV_txtBox.Text = Convert.ToBase64String(aesIV);
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

        private void OpenFile_btn_Click(object sender, EventArgs e)
        {
            string filePath = TxtFilePath.Text + ".enc";
            if (File.Exists(filePath))
            {
                try
                {
                    Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while opening the file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Encrypted file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
