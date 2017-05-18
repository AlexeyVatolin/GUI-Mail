using System;
using System.ComponentModel;

namespace GUI_Mail
{
    partial class FoldersManager
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
            this.foldersListView = new System.Windows.Forms.ListView();
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.Closed += new EventHandler(FolerManager_Closing);
            // 
            // foldersListView
            // 
            this.foldersListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.foldersListView.Location = new System.Drawing.Point(12, 12);
            this.foldersListView.Name = "foldersListView";
            this.foldersListView.Size = new System.Drawing.Size(260, 124);
            this.foldersListView.TabIndex = 0;
            this.foldersListView.UseCompatibleStateImageBehavior = false;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(12, 143);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 1;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // FoldersManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.foldersListView);
            this.Name = "FoldersManager";
            this.Text = "FoldersManager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView foldersListView;
        private System.Windows.Forms.Button Delete;
    }
}