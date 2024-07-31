namespace File_Encrypt_Decrypt_Tool_Forms
{
    partial class FileEncrypt_Decrypt
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnBrowse = new Button();
            BtnEncrypt = new Button();
            BtnDecrypt = new Button();
            TxtFilePath = new TextBox();
            TxtPassKey = new TextBox();
            LblFile = new Label();
            LblKey = new Label();
            SuspendLayout();
            // 
            // BtnBrowse
            // 
            BtnBrowse.Location = new Point(246, 29);
            BtnBrowse.Name = "BtnBrowse";
            BtnBrowse.Size = new Size(75, 23);
            BtnBrowse.TabIndex = 0;
            BtnBrowse.Text = "BROWSE";
            BtnBrowse.UseVisualStyleBackColor = true;
            BtnBrowse.Click += BtnBrowse_Click;
            // 
            // BtnEncrypt
            // 
            BtnEncrypt.Location = new Point(52, 113);
            BtnEncrypt.Name = "BtnEncrypt";
            BtnEncrypt.Size = new Size(75, 23);
            BtnEncrypt.TabIndex = 1;
            BtnEncrypt.Text = "ENCRYPT";
            BtnEncrypt.UseVisualStyleBackColor = true;
            BtnEncrypt.Click += BtnEncrypt_Click;
            // 
            // BtnDecrypt
            // 
            BtnDecrypt.Location = new Point(165, 113);
            BtnDecrypt.Name = "BtnDecrypt";
            BtnDecrypt.Size = new Size(75, 23);
            BtnDecrypt.TabIndex = 2;
            BtnDecrypt.Text = "DECRYPT";
            BtnDecrypt.UseVisualStyleBackColor = true;
            BtnDecrypt.Click += BtnDecrypt_Click;
            // 
            // TxtFilePath
            // 
            TxtFilePath.Location = new Point(52, 31);
            TxtFilePath.Name = "TxtFilePath";
            TxtFilePath.Size = new Size(188, 21);
            TxtFilePath.TabIndex = 3;
            // 
            // TxtPassKey
            // 
            TxtPassKey.Location = new Point(52, 64);
            TxtPassKey.Name = "TxtPassKey";
            TxtPassKey.Size = new Size(188, 21);
            TxtPassKey.TabIndex = 4;
            // 
            // LblFile
            // 
            LblFile.AutoSize = true;
            LblFile.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblFile.Location = new Point(12, 31);
            LblFile.Name = "LblFile";
            LblFile.Size = new Size(34, 18);
            LblFile.TabIndex = 5;
            LblFile.Text = "File";
            // 
            // LblKey
            // 
            LblKey.AutoSize = true;
            LblKey.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblKey.Location = new Point(12, 64);
            LblKey.Name = "LblKey";
            LblKey.Size = new Size(35, 18);
            LblKey.TabIndex = 6;
            LblKey.Text = "Key";
            // 
            // FileEncrypt_Decrypt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(339, 158);
            Controls.Add(LblKey);
            Controls.Add(LblFile);
            Controls.Add(TxtPassKey);
            Controls.Add(TxtFilePath);
            Controls.Add(BtnDecrypt);
            Controls.Add(BtnEncrypt);
            Controls.Add(BtnBrowse);
            Font = new Font("Arial", 9F);
            Name = "FileEncrypt_Decrypt";
            Text = "File Encrypt and Decrypt Tool";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnBrowse;
        private Button BtnEncrypt;
        private Button BtnDecrypt;
        private TextBox TxtFilePath;
        private TextBox TxtPassKey;
        private Label LblFile;
        private Label LblKey;
    }
}
