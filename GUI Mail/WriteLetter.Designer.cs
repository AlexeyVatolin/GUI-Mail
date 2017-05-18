namespace GUI_Mail
{
    partial class WriteLetter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WriteLetter));
            this.emailTo = new System.Windows.Forms.TextBox();
            this.subject = new System.Windows.Forms.TextBox();
            this.letterText = new System.Windows.Forms.RichTextBox();
            this.send = new System.Windows.Forms.Button();
            this.saveDraft = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // emailTo
            // 
            this.emailTo.Location = new System.Drawing.Point(32, 27);
            this.emailTo.Name = "emailTo";
            this.emailTo.Size = new System.Drawing.Size(398, 20);
            this.emailTo.TabIndex = 0;
            this.emailTo.Text = "Email to";
            // 
            // subject
            // 
            this.subject.Location = new System.Drawing.Point(32, 53);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(398, 20);
            this.subject.TabIndex = 1;
            this.subject.Text = "Subject";
            // 
            // letterText
            // 
            this.letterText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.letterText.Location = new System.Drawing.Point(0, 0);
            this.letterText.Name = "letterText";
            this.letterText.Size = new System.Drawing.Size(397, 195);
            this.letterText.TabIndex = 2;
            this.letterText.Text = "Text";
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(32, 292);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(75, 23);
            this.send.TabIndex = 3;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // saveDraft
            // 
            this.saveDraft.Location = new System.Drawing.Point(297, 292);
            this.saveDraft.Name = "saveDraft";
            this.saveDraft.Size = new System.Drawing.Size(75, 23);
            this.saveDraft.TabIndex = 4;
            this.saveDraft.Text = "Save draft";
            this.saveDraft.UseVisualStyleBackColor = true;
            this.saveDraft.Click += new System.EventHandler(this.saveDraft_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(385, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 45);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.letterText);
            this.panel1.Location = new System.Drawing.Point(32, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 196);
            this.panel1.TabIndex = 6;
            // 
            // WriteLetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 370);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.saveDraft);
            this.Controls.Add(this.send);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.emailTo);
            this.Location = new System.Drawing.Point(2, 2);
            this.Name = "WriteLetter";
            this.Text = "WriteLetter";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailTo;
        private System.Windows.Forms.TextBox subject;
        private System.Windows.Forms.RichTextBox letterText;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Button saveDraft;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}