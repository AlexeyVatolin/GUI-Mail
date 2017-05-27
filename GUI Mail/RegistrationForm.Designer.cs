namespace GUI_Mail
{
    partial class RegistrationForm
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.register = new System.Windows.Forms.Button();
            this.passwordAgain = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.TextBox();
            this.nameAndSurname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(87, 316);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(117, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Already have account?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(104, 243);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(75, 23);
            this.register.TabIndex = 4;
            this.register.Text = "Registration";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // passwordAgain
            // 
            this.passwordAgain.Location = new System.Drawing.Point(67, 206);
            this.passwordAgain.Name = "passwordAgain";
            this.passwordAgain.PasswordChar = '•';
            this.passwordAgain.Size = new System.Drawing.Size(156, 20);
            this.passwordAgain.TabIndex = 3;
            this.passwordAgain.Text = "Password again";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(67, 168);
            this.password.Name = "password";
            this.password.PasswordChar = '•';
            this.password.Size = new System.Drawing.Size(156, 20);
            this.password.TabIndex = 2;
            this.password.Text = "Password";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(67, 126);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(156, 20);
            this.login.TabIndex = 1;
            this.login.Text = "Login";
            // 
            // nameAndSurname
            // 
            this.nameAndSurname.Location = new System.Drawing.Point(67, 83);
            this.nameAndSurname.Name = "nameAndSurname";
            this.nameAndSurname.Size = new System.Drawing.Size(156, 20);
            this.nameAndSurname.TabIndex = 0;
            this.nameAndSurname.Text = "Name and Surname";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 338);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.register);
            this.Controls.Add(this.passwordAgain);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.nameAndSurname);
            this.MaximumSize = new System.Drawing.Size(313, 377);
            this.MinimumSize = new System.Drawing.Size(313, 377);
            this.Name = "RegistrationForm";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameAndSurname;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox passwordAgain;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}