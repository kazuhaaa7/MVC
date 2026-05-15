using MVC.View;

namespace MVC.View
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            TbUsername = new TextBox();
            TbPassword = new TextBox();
            BtnLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(323, 34);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(359, 342);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // TbUsername
            // 
            TbUsername.BackColor = SystemColors.HighlightText;
            TbUsername.BorderStyle = BorderStyle.None;
            TbUsername.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbUsername.Location = new Point(400, 230);
            TbUsername.Margin = new Padding(2);
            TbUsername.Name = "TbUsername";
            TbUsername.PlaceholderText = "Username";
            TbUsername.Size = new Size(181, 20);
            TbUsername.TabIndex = 1;
            // 
            // TbPassword
            // 
            TbPassword.BackColor = SystemColors.HighlightText;
            TbPassword.BorderStyle = BorderStyle.None;
            TbPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbPassword.Location = new Point(400, 284);
            TbPassword.Margin = new Padding(2);
            TbPassword.Name = "TbPassword";
            TbPassword.PasswordChar = '*';
            TbPassword.PlaceholderText = "Password";
            TbPassword.Size = new Size(181, 20);
            TbPassword.TabIndex = 2;
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = SystemColors.MenuHighlight;
            BtnLogin.FlatStyle = FlatStyle.Flat;
            BtnLogin.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnLogin.ForeColor = Color.Coral;
            BtnLogin.Location = new Point(543, 332);
            BtnLogin.Margin = new Padding(2);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(90, 27);
            BtnLogin.TabIndex = 3;
            BtnLogin.Text = "LOGIN";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(954, 473);
            Controls.Add(BtnLogin);
            Controls.Add(TbPassword);
            Controls.Add(TbUsername);
            Controls.Add(pictureBox1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox TbUsername;
        private TextBox TbPassword;
        private Button BtnLogin;
    }
}
