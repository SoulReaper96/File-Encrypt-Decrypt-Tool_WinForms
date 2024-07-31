using System.Security.Cryptography;
using System.Text;

namespace File_Encrypt_Decrypt_Tool_Forms
{
    public partial class FileEncrypt_Decrypt : Form
    {
        //Use Thats my Kung Fu as the key

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

        private void BtnEncrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtFilePath.Text) || string.IsNullOrEmpty(TxtPassKey.Text))
            {
                MessageBox.Show("Please provide both file path and password.");
                return;
            }

            try
            {
                EncryptFile(TxtFilePath.Text, TxtPassKey.Text);
                MessageBox.Show("File encrypted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BtnDecrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtFilePath.Text) || string.IsNullOrEmpty(TxtPassKey.Text))
            {
                MessageBox.Show("Please provide both file path and password.");
                return;
            }

            try
            {
                DecryptFile(TxtFilePath.Text, TxtPassKey.Text);
                MessageBox.Show("File decrypted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void EncryptFile(string filePath, string password)
        {
            byte[] fileBytes = File.ReadAllBytes(filePath);
            byte[] encryptedBytes = Encrypt(fileBytes, password);
            File.WriteAllBytes(filePath, encryptedBytes);
        }

        private void DecryptFile(string filePath, string password)
        {
            byte[] fileBytes = File.ReadAllBytes(filePath);
            byte[] decryptedBytes = Decrypt(fileBytes, password);
            File.WriteAllBytes(filePath, decryptedBytes);
        }

        private byte[] Encrypt(byte[] data, string password)
        {
            using (Aes aes = Aes.Create())
            {
                byte[] key = Encoding.UTF8.GetBytes(password.PadRight(32));
                aes.Key = key;
                aes.IV = new byte[16]; // Initialization vector (empty)

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(data, 0, data.Length);
                    }
                    return memoryStream.ToArray();
                }
            }
        }

        private byte[] Decrypt(byte[] data, string password)
        {
            using (Aes aes = Aes.Create())
            {
                byte[] key = Encoding.UTF8.GetBytes(password.PadRight(32));
                aes.Key = key;
                aes.IV = new byte[16]; // Initialization vector (empty)

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(data, 0, data.Length);
                    }
                    return memoryStream.ToArray();
                }
            }
        }
    }
}
