using System;
using System.Windows.Forms;

namespace GUI_Mail
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void register_Click(object sender, EventArgs e)
        {
            if (password.Text == passwordAgain.Text)
            {
                var dataWorker = DataWorker.Instance;
                if (!dataWorker.LoginExist(login.Text))
                {
                    dataWorker.AddUser(new User(nameAndSurname.Text, login.Text, password.Text));
                    DataWorker.CurrentUser = new User(nameAndSurname.Text, login.Text, password.Text);
                    var indox = new Inbox();
                    Hide();
                    indox.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show(this, "Username already exist", "Error", MessageBoxButtons.OK,
                      MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show(this, "Passwords do not match", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var loginForm = new LoginForm();
            Hide();
            loginForm.ShowDialog();
            Close();
        }
    }
}