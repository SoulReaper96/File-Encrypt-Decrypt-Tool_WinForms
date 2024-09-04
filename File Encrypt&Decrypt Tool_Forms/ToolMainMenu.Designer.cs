namespace File_Encrypt_Decrypt_Tool_Forms
{
    partial class ToolMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolMainMenu));
            Close_pb = new PictureBox();
            AES_btn = new Button();
            RSA_btn = new Button();
            DES_btn = new Button();
            TripleDES_btn = new Button();
            About_lbl = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)Close_pb).BeginInit();
            SuspendLayout();
            // 
            // Close_pb
            // 
            Close_pb.BackColor = Color.Transparent;
            Close_pb.Image = (Image)resources.GetObject("Close_pb.Image");
            Close_pb.Location = new Point(340, 12);
            Close_pb.Name = "Close_pb";
            Close_pb.Size = new Size(25, 25);
            Close_pb.SizeMode = PictureBoxSizeMode.StretchImage;
            Close_pb.TabIndex = 9;
            Close_pb.TabStop = false;
            Close_pb.Click += Close_pb_Click;
            // 
            // AES_btn
            // 
            AES_btn.BackColor = Color.Transparent;
            AES_btn.FlatAppearance.BorderColor = Color.LightYellow;
            AES_btn.FlatAppearance.BorderSize = 3;
            AES_btn.FlatStyle = FlatStyle.Flat;
            AES_btn.Font = new Font("Arial", 12F, FontStyle.Bold);
            AES_btn.ForeColor = Color.Gold;
            AES_btn.Location = new Point(76, 84);
            AES_btn.Name = "AES_btn";
            AES_btn.Size = new Size(70, 70);
            AES_btn.TabIndex = 10;
            AES_btn.Text = "AES";
            AES_btn.UseVisualStyleBackColor = false;
            AES_btn.Click += AES_btn_Click;
            // 
            // RSA_btn
            // 
            RSA_btn.BackColor = Color.Transparent;
            RSA_btn.FlatAppearance.BorderColor = Color.LightYellow;
            RSA_btn.FlatAppearance.BorderSize = 3;
            RSA_btn.FlatStyle = FlatStyle.Flat;
            RSA_btn.Font = new Font("Arial", 12F, FontStyle.Bold);
            RSA_btn.ForeColor = Color.Gold;
            RSA_btn.Location = new Point(222, 84);
            RSA_btn.Name = "RSA_btn";
            RSA_btn.Size = new Size(70, 70);
            RSA_btn.TabIndex = 11;
            RSA_btn.Text = "RSA";
            RSA_btn.UseVisualStyleBackColor = false;
            // 
            // DES_btn
            // 
            DES_btn.BackColor = Color.Transparent;
            DES_btn.FlatAppearance.BorderColor = Color.LightYellow;
            DES_btn.FlatAppearance.BorderSize = 3;
            DES_btn.FlatStyle = FlatStyle.Flat;
            DES_btn.Font = new Font("Arial", 12F, FontStyle.Bold);
            DES_btn.ForeColor = Color.Gold;
            DES_btn.Location = new Point(76, 171);
            DES_btn.Name = "DES_btn";
            DES_btn.Size = new Size(70, 70);
            DES_btn.TabIndex = 12;
            DES_btn.Text = "DES";
            DES_btn.UseVisualStyleBackColor = false;
            DES_btn.Click += DES_btn_Click;
            // 
            // TripleDES_btn
            // 
            TripleDES_btn.BackColor = Color.Transparent;
            TripleDES_btn.FlatAppearance.BorderColor = Color.LightYellow;
            TripleDES_btn.FlatAppearance.BorderSize = 3;
            TripleDES_btn.FlatStyle = FlatStyle.Flat;
            TripleDES_btn.Font = new Font("Arial", 10F, FontStyle.Bold);
            TripleDES_btn.ForeColor = Color.Gold;
            TripleDES_btn.Location = new Point(222, 171);
            TripleDES_btn.Name = "TripleDES_btn";
            TripleDES_btn.Size = new Size(70, 70);
            TripleDES_btn.TabIndex = 13;
            TripleDES_btn.Text = "TRIPLE DES";
            TripleDES_btn.UseVisualStyleBackColor = false;
            // 
            // About_lbl
            // 
            About_lbl.AutoSize = true;
            About_lbl.BackColor = Color.Transparent;
            About_lbl.FlatStyle = FlatStyle.Flat;
            About_lbl.Font = new Font("Arial", 10F, FontStyle.Underline);
            About_lbl.ForeColor = Color.Gold;
            About_lbl.Location = new Point(296, 263);
            About_lbl.Name = "About_lbl";
            About_lbl.Size = new Size(54, 16);
            About_lbl.TabIndex = 14;
            About_lbl.Text = "ABOUT";
            About_lbl.Click += About_lbl_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Arial", 14F, FontStyle.Underline);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(23, 46);
            label2.Name = "label2";
            label2.Size = new Size(316, 22);
            label2.TabIndex = 15;
            label2.Text = "PLEASE SELECT A TOOL BELOW";
            // 
            // ToolMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(377, 301);
            Controls.Add(label2);
            Controls.Add(About_lbl);
            Controls.Add(TripleDES_btn);
            Controls.Add(DES_btn);
            Controls.Add(RSA_btn);
            Controls.Add(AES_btn);
            Controls.Add(Close_pb);
            Font = new Font("Arial", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ToolMainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ToolMainMenu";
            ((System.ComponentModel.ISupportInitialize)Close_pb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Close_pb;
        private Button AES_btn;
        private Button RSA_btn;
        private Button DES_btn;
        private Button TripleDES_btn;
        private Label About_lbl;
        private Label label2;
    }
}