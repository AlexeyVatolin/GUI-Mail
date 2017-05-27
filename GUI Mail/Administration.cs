using System;
using System.Text;
using System.Windows.Forms;

namespace GUI_Mail
{
    public partial class Administration : MyForm
    {
        public Administration()
        {
            InitializeComponent();
        }

        private void Administration_Load(object sender, EventArgs e)
        {
            userList.Columns.Add("Name");
            userList.Columns.Add("Login");
            userList.Columns.Add("Is admin");
            userList.CheckBoxes = true;
            userList.View = View.Details;

            var dataWorker = DataWorker.Instance;
            foreach (var user in dataWorker.GetUsers())
            {
                userList.Items.Add(new ListViewItem(new[] { user.Username, user.Login + "@mymail.com", user.IsAdmin ? "Yes" : "No" }));
            }

            userList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            userList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            var selectedUsers = userList.CheckedItems;
            if (selectedUsers.Count > 0)
            {
                var userLogins = new StringBuilder();
                for (int i = 0; i < selectedUsers.Count; i++)
                {
                    userLogins.Append(selectedUsers[i].SubItems[1].Text.Substring(0,
                        selectedUsers[i].SubItems[1].Text.IndexOf('@')));
                    if (i != selectedUsers.Count - 1)
                    {
                        userLogins.Append(", ");
                    }
                }

                var result = MessageBox.Show(this, $"Are you sure you want to remove users {userLogins}?", "Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var dataWorker = DataWorker.Instance;
                    for (int i = 0; i < selectedUsers.Count; i++)
                    {
                        var selectedUserLogin = dataWorker.SelectLogin(selectedUsers[i].SubItems[1].Text);
                        if (selectedUserLogin != DataWorker.CurrentUser.Login)
                        {
                            selectedUsers[i].Remove();
                            i--;
                            dataWorker.DeleteUser(selectedUserLogin);
                        }
                    }
                }
            }
        }

        private void makeAdmin_Click(object sender, EventArgs e)
        {
            var selectedUsers = userList.CheckedItems;
            if (selectedUsers.Count > 0)
            {
                var dataWorker = DataWorker.Instance;
                
                for (int i = 0; i < selectedUsers.Count; i++)
                {
                    var selectedUserLogin = selectedUsers[i].SubItems[1].Text.Substring(0,
                        selectedUsers[i].SubItems[1].Text.IndexOf('@'));
                    if (selectedUserLogin != DataWorker.CurrentUser.Login)
                    {
                        if (selectedUsers[i].SubItems[2].Text == "Yes")
                        {
                            selectedUsers[i].SubItems[2].Text = "No";
                        }
                        else
                        {
                            selectedUsers[i].SubItems[2].Text = "Yes";
                        }
                        dataWorker.ChangeAdminState(selectedUserLogin);
                    }
                }
            }
        }
    }
}