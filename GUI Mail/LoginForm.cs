using System;
using System.Windows.Forms;

namespace GUI_Mail
{
    public partial class LoginForm : MyForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void registration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var registrationForm = new RegistrationForm();
            Hide();
            registrationForm.ShowDialog();
            Close();

        }

        private void settings_Click(object sender, EventArgs e)
        {
            new PersonalizationForm().ShowDialog();
        }

        private void signIn_Click(object sender, EventArgs e)
        {
            var dataWorker = DataWorker.Instance;
            var accountCkeckResult = dataWorker.Login(login.Text, password.Text);
            if (accountCkeckResult == DataWorker.LoginErrors.UsernameNotExist)
            {
                MessageBox.Show(this, "Username does not exist", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else if (accountCkeckResult == DataWorker.LoginErrors.PasswordNotCorrect)
            {
                MessageBox.Show(this, "Password does not correct", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                var indoxForm = new Inbox();
                Hide();
                indoxForm.ShowDialog();
                Close();
            }
        }
    }
}