using System;
using System.Windows.Forms;

namespace GUI_Mail
{
    public partial class PersonalizationForm : MyForm
    {
        public Inbox Inbox;

        public PersonalizationForm()
        {
            InitializeComponent();
        }

        public PersonalizationForm(Inbox inbox)
        {
            InitializeComponent();
            Inbox = inbox;
        }

        private void PersonalizationForm_Load(object sender, EventArgs e)
        {
            changeColor.Text = DataWorker.CurrentUser.Theme;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            DataWorker dataWorker = DataWorker.Instance;
            if (changeColor.SelectedIndex == 0)
            {
                dataWorker.ChangeTheme("Default");
            }
            else
            {
                dataWorker.ChangeTheme("Green");
            }
            dataWorker.ChangeSignature(signature.Text);
            Close();
            Inbox?.PerformRefresh();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}