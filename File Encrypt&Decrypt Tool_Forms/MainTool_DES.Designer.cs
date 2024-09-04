namespace File_Encrypt_Decrypt_Tool_Forms
{
    partial class MainTool_DES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainTool_DES));
            OpenFile_btn = new Button();
            GenerateKey_btn = new Button();
            Return_pb = new PictureBox();
            Close_pb = new PictureBox();
            IV_txtBox = new TextBox();
            Key_lbl = new Label();
            LblFile = new Label();
            Key_txtBox = new TextBox();
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
            OpenFile_btn.Location = new Point(166, 149);
            OpenFile_btn.Name = "OpenFile_btn";
            OpenFile_btn.Size = new Size(75, 23);
            OpenFile_btn.TabIndex = 23;
            OpenFile_btn.Text = "VIEW FILE";
            OpenFile_btn.UseVisualStyleBackColor = true;
            // 
            // GenerateKey_btn
            // 
            GenerateKey_btn.Location = new Point(163, 15);
            GenerateKey_btn.Name = "GenerateKey_btn";
            GenerateKey_btn.Size = new Size(150, 30);
            GenerateKey_btn.TabIndex = 22;
            GenerateKey_btn.Text = "GENERATE KEY";
            GenerateKey_btn.UseVisualStyleBackColor = true;
            GenerateKey_btn.Click += GenerateKey_btn_Click;
            // 
            // Return_pb
            // 
            Return_pb.Image = (Image)resources.GetObject("Return_pb.Image");
            Return_pb.Location = new Point(335, 9);
            Return_pb.Name = "Return_pb";
            Return_pb.Size = new Size(25, 25);
            Return_pb.SizeMode = PictureBoxSizeMode.StretchImage;
            Return_pb.TabIndex = 21;
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
            Close_pb.TabIndex = 20;
            Close_pb.TabStop = false;
            Close_pb.Click += Close_pb_Click;
            // 
            // IV_txtBox
            // 
            IV_txtBox.Location = new Point(247, 51);
            IV_txtBox.Name = "IV_txtBox";
            IV_txtBox.Size = new Size(120, 21);
            IV_txtBox.TabIndex = 19;
            // 
            // Key_lbl
            // 
            Key_lbl.AutoSize = true;
            Key_lbl.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Key_lbl.ForeColor = Color.Black;
            Key_lbl.Location = new Point(10, 51);
            Key_lbl.Name = "Key_lbl";
            Key_lbl.Size = new Size(105, 18);
            Key_lbl.TabIndex = 18;
            Key_lbl.Text = "Algorithm Key";
            // 
            // LblFile
            // 
            LblFile.AutoSize = true;
            LblFile.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblFile.Location = new Point(51, 93);
            LblFile.Name = "LblFile";
            LblFile.Size = new Size(34, 18);
            LblFile.TabIndex = 17;
            LblFile.Text = "File";
            // 
            // Key_txtBox
            // 
            Key_txtBox.Location = new Point(121, 51);
            Key_txtBox.Name = "Key_txtBox";
            Key_txtBox.Size = new Size(120, 21);
            Key_txtBox.TabIndex = 16;
            // 
            // TxtFilePath
            // 
            TxtFilePath.Location = new Point(91, 93);
            TxtFilePath.Name = "TxtFilePath";
            TxtFilePath.Size = new Size(188, 21);
            TxtFilePath.TabIndex = 15;
            // 
            // BtnDecrypt
            // 
            BtnDecrypt.Location = new Point(204, 120);
            BtnDecrypt.Name = "BtnDecrypt";
            BtnDecrypt.Size = new Size(75, 23);
            BtnDecrypt.TabIndex = 14;
            BtnDecrypt.Text = "DECRYPT";
            BtnDecrypt.UseVisualStyleBackColor = true;
            BtnDecrypt.Click += BtnDecrypt_Click;
            // 
            // BtnEncrypt
            // 
            BtnEncrypt.Location = new Point(123, 120);
            BtnEncrypt.Name = "BtnEncrypt";
            BtnEncrypt.Size = new Size(75, 23);
            BtnEncrypt.TabIndex = 13;
            BtnEncrypt.Text = "ENCRYPT";
            BtnEncrypt.UseVisualStyleBackColor = true;
            BtnEncrypt.Click += BtnEncrypt_Click;
            // 
            // BtnBrowse
            // 
            BtnBrowse.Location = new Point(285, 91);
            BtnBrowse.Name = "BtnBrowse";
            BtnBrowse.Size = new Size(75, 23);
            BtnBrowse.TabIndex = 12;
            BtnBrowse.Text = "BROWSE";
            BtnBrowse.UseVisualStyleBackColor = true;
            BtnBrowse.Click += BtnBrowse_Click;
            // 
            // MainTool_DES
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
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainTool_DES";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainTool_DES";
            ((System.ComponentModel.ISupportInitialize)Return_pb).EndInit();
            ((System.ComponentModel.ISupportInitialize)Close_pb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OpenFile_btn;
        private Button GenerateKey_btn;
        private PictureBox Return_pb;
        private PictureBox Close_pb;
        private TextBox IV_txtBox;
        private Label Key_lbl;
        private Label LblFile;
        private TextBox Key_txtBox;
        private TextBox TxtFilePath;
        private Button BtnDecrypt;
        private Button BtnEncrypt;
        private Button BtnBrowse;
    }
}