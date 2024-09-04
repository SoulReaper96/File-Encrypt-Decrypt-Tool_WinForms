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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileEncrypt_Decrypt));
            BtnBrowse = new Button();
            BtnEncrypt = new Button();
            BtnDecrypt = new Button();
            TxtFilePath = new TextBox();
            Key_txtBox = new TextBox();
            LblFile = new Label();
            Key_lbl = new Label();
            IV_txtBox = new TextBox();
            Close_pb = new PictureBox();
            Return_pb = new PictureBox();
            GenerateKey_btn = new Button();
            OpenFile_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)Close_pb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Return_pb).BeginInit();
            SuspendLayout();
            // 
            // BtnBrowse
            // 
            BtnBrowse.Location = new Point(287, 88);
            BtnBrowse.Name = "BtnBrowse";
            BtnBrowse.Size = new Size(75, 23);
            BtnBrowse.TabIndex = 0;
            BtnBrowse.Text = "BROWSE";
            BtnBrowse.UseVisualStyleBackColor = true;
            BtnBrowse.Click += BtnBrowse_Click;
            // 
            // BtnEncrypt
            // 
            BtnEncrypt.Location = new Point(125, 117);
            BtnEncrypt.Name = "BtnEncrypt";
            BtnEncrypt.Size = new Size(75, 23);
            BtnEncrypt.TabIndex = 1;
            BtnEncrypt.Text = "ENCRYPT";
            BtnEncrypt.UseVisualStyleBackColor = true;
            BtnEncrypt.Click += BtnEncrypt_Click;
            // 
            // BtnDecrypt
            // 
            BtnDecrypt.Location = new Point(206, 117);
            BtnDecrypt.Name = "BtnDecrypt";
            BtnDecrypt.Size = new Size(75, 23);
            BtnDecrypt.TabIndex = 2;
            BtnDecrypt.Text = "DECRYPT";
            BtnDecrypt.UseVisualStyleBackColor = true;
            BtnDecrypt.Click += BtnDecrypt_Click;
            // 
            // TxtFilePath
            // 
            TxtFilePath.Location = new Point(93, 90);
            TxtFilePath.Name = "TxtFilePath";
            TxtFilePath.Size = new Size(188, 21);
            TxtFilePath.TabIndex = 3;
            // 
            // Key_txtBox
            // 
            Key_txtBox.Location = new Point(123, 48);
            Key_txtBox.Name = "Key_txtBox";
            Key_txtBox.Size = new Size(120, 21);
            Key_txtBox.TabIndex = 4;
            // 
            // LblFile
            // 
            LblFile.AutoSize = true;
            LblFile.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblFile.Location = new Point(53, 90);
            LblFile.Name = "LblFile";
            LblFile.Size = new Size(34, 18);
            LblFile.TabIndex = 5;
            LblFile.Text = "File";
            // 
            // Key_lbl
            // 
            Key_lbl.AutoSize = true;
            Key_lbl.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Key_lbl.Location = new Point(12, 48);
            Key_lbl.Name = "Key_lbl";
            Key_lbl.Size = new Size(105, 18);
            Key_lbl.TabIndex = 6;
            Key_lbl.Text = "Algorithm Key";
            // 
            // IV_txtBox
            // 
            IV_txtBox.Location = new Point(249, 48);
            IV_txtBox.Name = "IV_txtBox";
            IV_txtBox.Size = new Size(120, 21);
            IV_txtBox.TabIndex = 7;
            // 
            // Close_pb
            // 
            Close_pb.Image = (Image)resources.GetObject("Close_pb.Image");
            Close_pb.Location = new Point(368, 6);
            Close_pb.Name = "Close_pb";
            Close_pb.Size = new Size(25, 25);
            Close_pb.SizeMode = PictureBoxSizeMode.StretchImage;
            Close_pb.TabIndex = 8;
            Close_pb.TabStop = false;
            Close_pb.Click += Close_pb_Click;
            // 
            // Return_pb
            // 
            Return_pb.Image = (Image)resources.GetObject("Return_pb.Image");
            Return_pb.Location = new Point(337, 6);
            Return_pb.Name = "Return_pb";
            Return_pb.Size = new Size(25, 25);
            Return_pb.SizeMode = PictureBoxSizeMode.StretchImage;
            Return_pb.TabIndex = 9;
            Return_pb.TabStop = false;
            // 
            // GenerateKey_btn
            // 
            GenerateKey_btn.Location = new Point(165, 12);
            GenerateKey_btn.Name = "GenerateKey_btn";
            GenerateKey_btn.Size = new Size(150, 30);
            GenerateKey_btn.TabIndex = 10;
            GenerateKey_btn.Text = "GENERATE KEY";
            GenerateKey_btn.UseVisualStyleBackColor = true;
            GenerateKey_btn.Click += GenerateKey_btn_Click;
            // 
            // OpenFile_btn
            // 
            OpenFile_btn.Location = new Point(168, 146);
            OpenFile_btn.Name = "OpenFile_btn";
            OpenFile_btn.Size = new Size(75, 23);
            OpenFile_btn.TabIndex = 11;
            OpenFile_btn.Text = "VIEW FILE";
            OpenFile_btn.UseVisualStyleBackColor = true;
            // 
            // FileEncrypt_Decrypt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(400, 180);
            Controls.Add(OpenFile_btn);
            Controls.Add(GenerateKey_btn);
            Controls.Add(Return_pb);
            Controls.Add(Close_pb);
            Controls.Add(IV_txtBox);
            Controls.Add(Key_lbl);
            Controls.Add(LblFile);
            Controls.Add(Key_txtBox);
            Controls.Add(TxtFilePath);
            Controls.Add(BtnDecrypt);
            Controls.Add(BtnEncrypt);
            Controls.Add(BtnBrowse);
            Font = new Font("Arial", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FileEncrypt_Decrypt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AES Algorithm";
            ((System.ComponentModel.ISupportInitialize)Close_pb).EndInit();
            ((System.ComponentModel.ISupportInitialize)Return_pb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnBrowse;
        private Button BtnEncrypt;
        private Button BtnDecrypt;
        private TextBox TxtFilePath;
        private TextBox Key_txtBox;
        private Label LblFile;
        private Label Key_lbl;
        private TextBox IV_txtBox;
        private PictureBox Close_pb;
        private PictureBox Return_pb;
        private Button GenerateKey_btn;
        private Button OpenFile_btn;
    }
}
