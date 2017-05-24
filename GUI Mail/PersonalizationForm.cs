using System;
using System.Windows.Forms;

namespace GUI_Mail
{
    public partial class PersonalizationForm : Form
    {
        public PersonalizationForm()
        {
            InitializeComponent();
        }

        private void PersonalizationForm_Load(object sender, EventArgs e)
        {
            changeColor.Items.Add("Blue");
            changeColor.Items.Add("Black");
            changeColor.Items.Add("Red");
            changeColor.Items.Add("Green");
        }

        private void submit_Click(object sender, EventArgs e)
        {
            DataWorker.CurrentUser.ChangeSignature(signature.Text);
            Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}