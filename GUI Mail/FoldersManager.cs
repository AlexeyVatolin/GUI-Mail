using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Mail
{
    public partial class FoldersManager : Form
    {
        public FoldersManager()
        {
            InitializeComponent();
            foldersListView.Columns.Add("Folder name");
            foldersListView.View = View.Details;
            LoadFolders();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (foldersListView.SelectedItems.Count == 0)
            {
                MessageBox.Show(this, "Select folder before delete", "Select folder", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                var confirm = MessageBox.Show(this,
                    "Are you sure that you want to delete the folder and all the mails within it?", "Are you sure?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    var dataWorker = DataWorker.Instance;
                    dataWorker.DeleteFolder(foldersListView.SelectedItems[0].Text);
                }
                LoadFolders();
            }
        }

        private void LoadFolders()
        {
            var dataWorker = DataWorker.Instance;
            foldersListView.Items.Clear();
            foreach (var folder in dataWorker.GetFolders())
            {
                foldersListView.Items.Add(new ListViewItem(folder));
            }
            foldersListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void FolerManager_Closing(object sender, EventArgs e)
        {
            var inbox = new Inbox();
            Hide();
            inbox.ShowDialog();
            Close();
        }
    }
}
