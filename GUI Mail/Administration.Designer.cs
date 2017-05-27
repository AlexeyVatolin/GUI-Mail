namespace GUI_Mail
{
    partial class Administration
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
            this.makeAdmin = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.userList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // makeAdmin
            // 
            this.makeAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.makeAdmin.AutoSize = true;
            this.makeAdmin.Location = new System.Drawing.Point(385, 286);
            this.makeAdmin.Name = "makeAdmin";
            this.makeAdmin.Size = new System.Drawing.Size(111, 23);
            this.makeAdmin.TabIndex = 2;
            this.makeAdmin.Text = "Change admin state";
            this.makeAdmin.UseVisualStyleBackColor = true;
            this.makeAdmin.Click += new System.EventHandler(this.makeAdmin_Click);
            // 
            // delete
            // 
            this.delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.delete.Location = new System.Drawing.Point(25, 286);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 1;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // userList
            // 
            this.userList.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.userList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userList.Location = new System.Drawing.Point(25, 29);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(471, 230);
            this.userList.TabIndex = 0;
            this.userList.UseCompatibleStateImageBehavior = false;
            // 
            // Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 337);
            this.Controls.Add(this.makeAdmin);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.userList);
            this.MinimumSize = new System.Drawing.Size(542, 376);
            this.Name = "Administration";
            this.Text = "Administration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView userList;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button makeAdmin;
    }
}