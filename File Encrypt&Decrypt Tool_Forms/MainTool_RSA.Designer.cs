namespace File_Encrypt_Decrypt_Tool_Forms
{
    partial class MainTool_RSA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainTool_RSA));
            OpenFile_btn = new Button();
            Return_pb = new PictureBox();
            Close_pb = new PictureBox();
            LblFile = new Label();
            TxtFilePath = new TextBox();
            BtnDecrypt = new Button();
            BtnEncrypt = new Button();
            BtnBrowse = new Button();
            ((System.ComponentModel.ISupportInitialize)Return_pb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Close_pb).BeginInit();
            SuspendLayout();
            // 
            // OpenFile_btn
            // 
            OpenFile_btn.Location = new Point(165, 107);
            OpenFile_btn.Name = "OpenFile_btn";
            OpenFile_btn.Size = new Size(75, 23);
            OpenFile_btn.TabIndex = 47;
            OpenFile_btn.Text = "VIEW FILE";
            OpenFile_btn.UseVisualStyleBackColor = true;
            // 
            // Return_pb
            // 
            Return_pb.Image = (Image)resources.GetObject("Return_pb.Image");
            Return_pb.Location = new Point(335, 9);
            Return_pb.Name = "Return_pb";
            Return_pb.Size = new Size(25, 25);
            Return_pb.SizeMode = PictureBoxSizeMode.StretchImage;
            Return_pb.TabIndex = 45;
            Return_pb.TabStop = false;
            Return_pb.Click += Return_pb_Click;
            // 
            // Close_pb
            // 
            Close_pb.Image = (Image)resources.GetObject("Close_pb.Image");
            Close_pb.Location = new Point(366, 9);
            Close_pb.Name = "Close_pb";
            Close_pb.Size = new Size(25, 25);
            Close_pb.SizeMode = PictureBoxSizeMode.StretchImage;
            Close_pb.TabIndex = 44;
            Close_pb.TabStop = false;
            Close_pb.Click += Close_pb_Click;
            // 
            // LblFile
            // 
            LblFile.AutoSize = true;
            LblFile.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblFile.Location = new Point(50, 51);
            LblFile.Name = "LblFile";
            LblFile.Size = new Size(34, 18);
            LblFile.TabIndex = 41;
            LblFile.Text = "File";
            // 
            // TxtFilePath
            // 
            TxtFilePath.Location = new Point(90, 51);
            TxtFilePath.Name = "TxtFilePath";
            TxtFilePath.Size = new Size(188, 21);
            TxtFilePath.TabIndex = 39;
            // 
            // BtnDecrypt
            // 
            BtnDecrypt.Location = new Point(203, 78);
            BtnDecrypt.Name = "BtnDecrypt";
            BtnDecrypt.Size = new Size(75, 23);
            BtnDecrypt.TabIndex = 38;
            BtnDecrypt.Text = "DECRYPT";
            BtnDecrypt.UseVisualStyleBackColor = true;
            BtnDecrypt.Click += BtnDecrypt_Click;
            // 
            // BtnEncrypt
            // 
            BtnEncrypt.Location = new Point(122, 78);
            BtnEncrypt.Name = "BtnEncrypt";
            BtnEncrypt.Size = new Size(75, 23);
            BtnEncrypt.TabIndex = 37;
            BtnEncrypt.Text = "ENCRYPT";
            BtnEncrypt.UseVisualStyleBackColor = true;
            BtnEncrypt.Click += BtnEncrypt_Click;
            // 
            // BtnBrowse
            // 
            BtnBrowse.Location = new Point(284, 49);
            BtnBrowse.Name = "BtnBrowse";
            BtnBrowse.Size = new Size(75, 23);
            BtnBrowse.TabIndex = 36;
            BtnBrowse.Text = "BROWSE";
            BtnBrowse.UseVisualStyleBackColor = true;
            BtnBrowse.Click += BtnBrowse_Click;
            // 
            // MainTool_RSA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(400, 141);
            Controls.Add(OpenFile_btn);
            Controls.Add(Return_pb);
            Controls.Add(Close_pb);
            Controls.Add(LblFile);
            Controls.Add(TxtFilePath);
            Controls.Add(BtnDecrypt);
            Controls.Add(BtnEncrypt);
            Controls.Add(BtnBrowse);
            Font = new Font("Arial", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainTool_RSA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainTool_RSA";
            ((System.ComponentModel.ISupportInitialize)Return_pb).EndInit();
            ((System.ComponentModel.ISupportInitialize)Close_pb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OpenFile_btn;
        private PictureBox Return_pb;
        private PictureBox Close_pb;
        private Label LblFile;
        private TextBox TxtFilePath;
        private Button BtnDecrypt;
        private Button BtnEncrypt;
        private Button BtnBrowse;
    }
}