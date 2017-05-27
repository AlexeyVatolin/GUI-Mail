using System;
using System.Windows.Forms;

namespace GUI_Mail
{
    partial class Inbox
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inbox));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openContactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openContactsInWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.mailList = new System.Windows.Forms.ListView();
            this.newMessage = new System.Windows.Forms.Button();
            this.deleteFolder = new System.Windows.Forms.Button();
            this.addFolder = new System.Windows.Forms.Button();
            this.foldersLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.foldersPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.mailText = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Refresh = new System.Windows.Forms.Button();
            this.DeleteLetter = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.Label();
            this.mailMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.moveToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openInWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.foldersLayoutPanel.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.mailMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(509, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openContactsToolStripMenuItem,
            this.openContactsInWordToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openContactsToolStripMenuItem
            // 
            this.openContactsToolStripMenuItem.Name = "openContactsToolStripMenuItem";
            this.openContactsToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.openContactsToolStripMenuItem.Text = "Open contacts in Excel";
            this.openContactsToolStripMenuItem.Click += new System.EventHandler(this.openContactsToolStripMenuItem_Click);
            // 
            // openContactsInWordToolStripMenuItem
            // 
            this.openContactsInWordToolStripMenuItem.Name = "openContactsInWordToolStripMenuItem";
            this.openContactsInWordToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.openContactsInWordToolStripMenuItem.Text = "Open contacts in Word";
            this.openContactsInWordToolStripMenuItem.Click += new System.EventHandler(this.openContactsInWordToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.editToolStripMenuItem.Text = "Edit profile";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(452, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 45);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.PersonalizationButton_Click);
            // 
            // mailList
            // 
            this.mailList.FullRowSelect = true;
            this.mailList.Location = new System.Drawing.Point(132, 63);
            this.mailList.MinimumSize = new System.Drawing.Size(365, 4);
            this.mailList.Name = "mailList";
            this.mailList.Size = new System.Drawing.Size(365, 174);
            this.mailList.TabIndex = 5;
            this.mailList.UseCompatibleStateImageBehavior = false;
            this.mailList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mailList_ItemClicked);
            // 
            // newMessage
            // 
            this.newMessage.Location = new System.Drawing.Point(8, 63);
            this.newMessage.Name = "newMessage";
            this.newMessage.Size = new System.Drawing.Size(96, 36);
            this.newMessage.TabIndex = 6;
            this.newMessage.Text = "Write new message";
            this.newMessage.UseVisualStyleBackColor = true;
            this.newMessage.Click += new System.EventHandler(this.newMessage_Click);
            // 
            // deleteFolder
            // 
            this.deleteFolder.Image = ((System.Drawing.Image)(resources.GetObject("deleteFolder.Image")));
            this.deleteFolder.Location = new System.Drawing.Point(54, 3);
            this.deleteFolder.Name = "deleteFolder";
            this.deleteFolder.Size = new System.Drawing.Size(45, 45);
            this.deleteFolder.TabIndex = 10;
            this.deleteFolder.UseVisualStyleBackColor = true;
            this.deleteFolder.Click += new System.EventHandler(this.deleteFolder_Click);
            // 
            // addFolder
            // 
            this.addFolder.Image = ((System.Drawing.Image)(resources.GetObject("addFolder.Image")));
            this.addFolder.Location = new System.Drawing.Point(3, 3);
            this.addFolder.Name = "addFolder";
            this.addFolder.Size = new System.Drawing.Size(45, 45);
            this.addFolder.TabIndex = 11;
            this.addFolder.UseVisualStyleBackColor = true;
            this.addFolder.Click += new System.EventHandler(this.addFolder_Click);
            // 
            // foldersLayoutPanel
            // 
            this.foldersLayoutPanel.AutoSize = true;
            this.foldersLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.foldersLayoutPanel.Controls.Add(this.foldersPanel);
            this.foldersLayoutPanel.Controls.Add(this.buttonsPanel);
            this.foldersLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.foldersLayoutPanel.Location = new System.Drawing.Point(4, 105);
            this.foldersLayoutPanel.Name = "foldersLayoutPanel";
            this.foldersLayoutPanel.Size = new System.Drawing.Size(122, 158);
            this.foldersLayoutPanel.TabIndex = 13;
            // 
            // foldersPanel
            // 
            this.foldersPanel.AutoScroll = true;
            this.foldersPanel.AutoScrollMinSize = new System.Drawing.Size(102, 87);
            this.foldersPanel.AutoSize = true;
            this.foldersPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.foldersPanel.Location = new System.Drawing.Point(0, 10);
            this.foldersPanel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.foldersPanel.MaximumSize = new System.Drawing.Size(0, 250);
            this.foldersPanel.MinimumSize = new System.Drawing.Size(102, 87);
            this.foldersPanel.Name = "foldersPanel";
            this.foldersPanel.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.foldersPanel.Size = new System.Drawing.Size(102, 87);
            this.foldersPanel.TabIndex = 14;
            this.foldersPanel.WrapContents = false;
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.AutoSize = true;
            this.buttonsPanel.Controls.Add(this.addFolder);
            this.buttonsPanel.Controls.Add(this.deleteFolder);
            this.buttonsPanel.Location = new System.Drawing.Point(0, 107);
            this.buttonsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(102, 51);
            this.buttonsPanel.TabIndex = 10;
            // 
            // mailText
            // 
            this.mailText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mailText.Location = new System.Drawing.Point(0, 0);
            this.mailText.MinimumSize = new System.Drawing.Size(363, 0);
            this.mailText.Name = "mailText";
            this.mailText.ReadOnly = true;
            this.mailText.Size = new System.Drawing.Size(363, 149);
            this.mailText.TabIndex = 14;
            this.mailText.Text = "";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.mailText);
            this.panel1.Location = new System.Drawing.Point(132, 243);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 151);
            this.panel1.TabIndex = 15;
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(133, 34);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(75, 23);
            this.Refresh.TabIndex = 16;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // DeleteLetter
            // 
            this.DeleteLetter.Location = new System.Drawing.Point(214, 34);
            this.DeleteLetter.Name = "DeleteLetter";
            this.DeleteLetter.Size = new System.Drawing.Size(75, 23);
            this.DeleteLetter.TabIndex = 17;
            this.DeleteLetter.Text = "Delete";
            this.DeleteLetter.UseVisualStyleBackColor = true;
            this.DeleteLetter.Click += new System.EventHandler(this.DeleteLetter_Click);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(13, 34);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(0, 13);
            this.Username.TabIndex = 18;
            // 
            // mailMenuStrip
            // 
            this.mailMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moveToToolStripMenuItem,
            this.openInWordToolStripMenuItem});
            this.mailMenuStrip.Name = "mailMenuStrip";
            this.mailMenuStrip.Size = new System.Drawing.Size(149, 48);
            // 
            // moveToToolStripMenuItem
            // 
            this.moveToToolStripMenuItem.Name = "moveToToolStripMenuItem";
            this.moveToToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.moveToToolStripMenuItem.Text = "Move to";
            // 
            // openInWordToolStripMenuItem
            // 
            this.openInWordToolStripMenuItem.Name = "openInWordToolStripMenuItem";
            this.openInWordToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.openInWordToolStripMenuItem.Text = "Open in Word";
            this.openInWordToolStripMenuItem.Click += new System.EventHandler(this.openInWordToolStripMenuItem_Click);
            // 
            // Inbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(509, 406);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.DeleteLetter);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.foldersLayoutPanel);
            this.Controls.Add(this.newMessage);
            this.Controls.Add(this.mailList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Inbox";
            this.Text = "Inbox";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.foldersLayoutPanel.ResumeLayout(false);
            this.foldersLayoutPanel.PerformLayout();
            this.buttonsPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.mailMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView mailList;
        private System.Windows.Forms.Button newMessage;
        private System.Windows.Forms.Button deleteFolder;
        private System.Windows.Forms.Button addFolder;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel foldersLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel buttonsPanel;
        private System.Windows.Forms.FlowLayoutPanel foldersPanel;
        private System.Windows.Forms.RichTextBox mailText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button DeleteLetter;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Label Username;
        private ContextMenuStrip mailMenuStrip;
        private ToolStripMenuItem moveToToolStripMenuItem;
        private ToolStripMenuItem openInWordToolStripMenuItem;
        private ToolStripMenuItem openContactsToolStripMenuItem;
        private ToolStripMenuItem openContactsInWordToolStripMenuItem;
    }
}