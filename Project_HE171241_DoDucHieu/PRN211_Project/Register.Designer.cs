namespace PRN211_Project
{
    partial class frmRegister
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
            lblTitle = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            lblRepassword = new Label();
            txtPassword = new TextBox();
            txtRepassword = new TextBox();
            btnRegister = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(236, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(340, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Create your account";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.Location = new Point(163, 132);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(118, 31);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(317, 129);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(321, 38);
            txtUsername.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.Location = new Point(163, 202);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(112, 31);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // lblRepassword
            // 
            lblRepassword.AutoSize = true;
            lblRepassword.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblRepassword.Location = new Point(163, 275);
            lblRepassword.Name = "lblRepassword";
            lblRepassword.Size = new Size(148, 31);
            lblRepassword.TabIndex = 4;
            lblRepassword.Text = "Re-password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(317, 199);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(321, 38);
            txtPassword.TabIndex = 5;
            // 
            // txtRepassword
            // 
            txtRepassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtRepassword.Location = new Point(317, 272);
            txtRepassword.Name = "txtRepassword";
            txtRepassword.PasswordChar = '*';
            txtRepassword.Size = new Size(321, 38);
            txtRepassword.TabIndex = 6;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.Location = new Point(677, 394);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(111, 44);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(12, 394);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(111, 44);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnRegister);
            Controls.Add(txtRepassword);
            Controls.Add(txtPassword);
            Controls.Add(lblRepassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(lblTitle);
            Name = "frmRegister";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private Label lblRepassword;
        private TextBox txtPassword;
        private TextBox txtRepassword;
        private Button btnRegister;
        private Button btnCancel;
    }
}