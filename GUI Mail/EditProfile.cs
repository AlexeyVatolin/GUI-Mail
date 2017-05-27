using System;
using System.Windows.Forms;

namespace GUI_Mail
{
    public partial class EditProfile : MyForm
    {
        public EditProfile()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (password.Text == passwordAgain.Text)
            {
                var dataWorker = DataWorker.Instance;
                dataWorker.EditUserData(nameAndSurname.Text, password.Text);
                Hide();
            }
            else
            {
                MessageBox.Show(this, "Passwords do not match", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }
    }
}