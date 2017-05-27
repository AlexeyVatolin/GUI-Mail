using System;
using System.Windows.Forms;

namespace GUI_Mail
{
    public partial class WriteLetter : MyForm
    {
        public WriteLetter()
        {
            InitializeComponent();
            letterText.Text = "\n\n" + DataWorker.CurrentUser.Signature;
        }

        private void send_Click(object sender, EventArgs e)
        {
            var mail = new Mail(DataWorker.CurrentUser.Login + "@mymail.com", emailTo.Text, subject.Text, letterText.Text, "Inbox");
            DataWorker dataWorker = DataWorker.Instance;
            dataWorker.SendMail(mail);
            Hide();
        }

        private void saveDraft_Click(object sender, EventArgs e)
        {
            var mail = new Mail(DataWorker.CurrentUser.Login + "@mymail.com", emailTo.Text, subject.Text, letterText.Text, "Draft");
            DataWorker dataWorker = DataWorker.Instance;
            dataWorker.SendMail(mail);
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}