namespace GUI_Mail
{
    partial class EditProfile
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
            this.save = new System.Windows.Forms.Button();
            this.passwordAgain = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.nameAndSurname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(98, 173);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 5;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // passwordAgain
            // 
            this.passwordAgain.Location = new System.Drawing.Point(63, 130);
            this.passwordAgain.Name = "passwordAgain";
            this.passwordAgain.PasswordChar = '•';
            this.passwordAgain.Size = new System.Drawing.Size(156, 20);
            this.passwordAgain.TabIndex = 4;
            this.passwordAgain.Text = "Password again";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(63, 93);
            this.password.Name = "password";
            this.password.PasswordChar = '•';
            this.password.Size = new System.Drawing.Size(156, 20);
            this.password.TabIndex = 3;
            this.password.Text = "Password";
            // 
            // nameAndSurname
            // 
            this.nameAndSurname.Location = new System.Drawing.Point(63, 50);
            this.nameAndSurname.Name = "nameAndSurname";
            this.nameAndSurname.Size = new System.Drawing.Size(156, 20);
            this.nameAndSurname.TabIndex = 1;
            this.nameAndSurname.Text = "Name and Surname";
            // 
            // EditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.save);
            this.Controls.Add(this.passwordAgain);
            this.Controls.Add(this.password);
            this.Controls.Add(this.nameAndSurname);
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "EditProfile";
            this.Text = "Edit profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameAndSurname;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox passwordAgain;
        private System.Windows.Forms.Button save;
    }
}