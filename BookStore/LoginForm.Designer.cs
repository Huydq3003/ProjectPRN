﻿namespace BookStore_HoangNT
{
    partial class LoginForm
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
            btnLogin = new Button();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            lblAppName = new Label();
            gbLoginForm = new GroupBox();
            lblSignIn = new Label();
            gbLoginForm.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(255, 192, 192);
            btnLogin.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(130, 592);
            btnLogin.Margin = new Padding(6, 6, 6, 6);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(468, 90);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Sign in";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(130, 283);
            txtEmail.Margin = new Padding(6, 6, 6, 6);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(463, 46);
            txtEmail.TabIndex = 0;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(117, 223);
            lblEmail.Margin = new Padding(6, 0, 6, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(103, 39);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(130, 459);
            txtPassword.Margin = new Padding(6, 6, 6, 6);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = 'x';
            txtPassword.Size = new Size(463, 46);
            txtPassword.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(121, 406);
            lblPassword.Margin = new Padding(6, 0, 6, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(167, 39);
            lblPassword.TabIndex = 13;
            lblPassword.Text = "Password";
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblAppName.Location = new Point(312, 53);
            lblAppName.Margin = new Padding(6, 0, 6, 0);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(499, 89);
            lblAppName.TabIndex = 15;
            lblAppName.Text = "Book Manager";
            // 
            // gbLoginForm
            // 
            gbLoginForm.BackColor = Color.LimeGreen;
            gbLoginForm.Controls.Add(lblSignIn);
            gbLoginForm.Controls.Add(txtPassword);
            gbLoginForm.Controls.Add(btnLogin);
            gbLoginForm.Controls.Add(lblPassword);
            gbLoginForm.Controls.Add(txtEmail);
            gbLoginForm.Controls.Add(lblEmail);
            gbLoginForm.FlatStyle = FlatStyle.Flat;
            gbLoginForm.Location = new Point(223, 199);
            gbLoginForm.Margin = new Padding(6, 6, 6, 6);
            gbLoginForm.Name = "gbLoginForm";
            gbLoginForm.Padding = new Padding(6, 6, 6, 6);
            gbLoginForm.Size = new Size(720, 744);
            gbLoginForm.TabIndex = 16;
            gbLoginForm.TabStop = false;
            // 
            // lblSignIn
            // 
            lblSignIn.AutoSize = true;
            lblSignIn.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblSignIn.Location = new Point(249, 47);
            lblSignIn.Margin = new Padding(6, 0, 6, 0);
            lblSignIn.Name = "lblSignIn";
            lblSignIn.Size = new Size(211, 74);
            lblSignIn.TabIndex = 17;
            lblSignIn.Text = "Sign In";
            // 
            // LoginForm
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1173, 1076);
            Controls.Add(gbLoginForm);
            Controls.Add(lblAppName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(6, 6, 6, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += LoginForm_Load;
            gbLoginForm.ResumeLayout(false);
            gbLoginForm.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtPassword;
        private Label lblPassword;
        private Label lblAppName;
        private GroupBox gbLoginForm;
        private Label lblSignIn;
    }
}