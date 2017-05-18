namespace GUI_Mail
{
    partial class LoginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.signIn = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.Button();
            this.registration = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(83, 85);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(100, 20);
            this.login.TabIndex = 0;
            this.login.Text = "Login";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(83, 128);
            this.password.Name = "password";
            this.password.PasswordChar = '•';
            this.password.Size = new System.Drawing.Size(100, 20);
            this.password.TabIndex = 1;
            this.password.Text = "Password";
            // 
            // signIn
            // 
            this.signIn.Location = new System.Drawing.Point(94, 169);
            this.signIn.Name = "signIn";
            this.signIn.Size = new System.Drawing.Size(75, 23);
            this.signIn.TabIndex = 2;
            this.signIn.Text = "Sign in";
            this.signIn.UseVisualStyleBackColor = true;
            this.signIn.Click += new System.EventHandler(this.signIn_Click);
            // 
            // settings
            // 
            this.settings.Image = ((System.Drawing.Image)(resources.GetObject("settings.Image")));
            this.settings.Location = new System.Drawing.Point(227, 13);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(45, 45);
            this.settings.TabIndex = 3;
            this.settings.UseVisualStyleBackColor = true;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // registration
            // 
            this.registration.AutoSize = true;
            this.registration.Location = new System.Drawing.Point(103, 237);
            this.registration.Name = "registration";
            this.registration.Size = new System.Drawing.Size(63, 13);
            this.registration.TabIndex = 4;
            this.registration.TabStop = true;
            this.registration.Text = "Registration";
            this.registration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registration_LinkClicked);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.registration);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.signIn);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button signIn;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.LinkLabel registration;
    }
}

