using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
using Application = System.Windows.Forms.Application;
using Point = System.Drawing.Point;
using View = System.Windows.Forms.View;

namespace GUI_Mail
{
    public partial class Inbox : Form
    {
        private List<Mail> mails;
        private string currentFolder;

        public Inbox()
        {
            InitializeComponent();
            if (DataWorker.CurrentUser != null && DataWorker.CurrentUser.IsAdmin)
            {
                var adminButon = new ToolStripMenuItem("Admin panel");
                fileToolStripMenuItem.DropDownItems.Insert(0, adminButon);
                adminButon.Click += delegate
                {
                    var adminForm = new Administration();
                    adminForm.Show();
                };
            }
            Username.Text = DataWorker.CurrentUser.Login + "@mymail.com";
            mails = new List<Mail>();
            currentFolder = "Inbox";

            var dataWorker = DataWorker.Instance;
            foreach (var folder in dataWorker.GetFolders())
            {
                PlaceFolder(folder);
            }

            /*foreach (Button control in Controls.OfType<Button>())
            {
                control.BackColor = Color.Gray;
                control.ForeColor = Color.White;
            }*/
        }

        private void Inbox_Load(object sender, EventArgs e)
        {
            mailList.Columns.Add("Addres from");
            mailList.Columns.Add("Addres to");
            mailList.Columns.Add("Subject");
            mailList.CheckBoxes = true;
            mailList.View = View.Details;

            LoadMails("Inbox");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PersonalizationButton_Click(object sender, EventArgs e)
        {
            new PersonalizationForm().ShowDialog();
        }

        private void newMessage_Click(object sender, EventArgs e)
        {
            var writeLetter = new WriteLetter();
            writeLetter.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var editProfile = new EditProfile();
            editProfile.Show();
        }

        //Вызывается при нажатии на папку
        private void folder_Click(object sender, EventArgs e)
        {
            var senderButton = (Button)sender;
            if (senderButton != null)
            {
                LoadMails(senderButton.Text);
                currentFolder = senderButton.Text;
            }
        }

        private void addFolder_Click(object sender, EventArgs e)
        {
            var folderName = Dialog.ShowDialog();
            if (!Dialog.isCanceled && folderName != "")
            {
                var dataWorker = DataWorker.Instance;
                if (dataWorker.AddFolder(folderName))
                {
                    PlaceFolder(folderName, true);
                }
                else
                {
                    MessageBox.Show(this, "Folder with the same name already exists", "Folder already exists", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show(this, "Folder name field cann't be empty", "Empty field", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        //Помещение папки в боковое меню
        private void PlaceFolder(string folderName, bool onPenultPlace = false)
        {
            var newFolder = new Button { Size = new Size(96, 23), Text = folderName };
            newFolder.Click += folder_Click;
            foldersPanel.Controls.Add(newFolder);

            /*if (onPenultPlace)
            {
                var buttonPanelIndex = foldersPanel.Controls.GetChildIndex(spam);
                foldersPanel.Controls.SetChildIndex(newFolder, buttonPanelIndex);
            }*/
        }

        private void mailList_ItemClicked(object sender, MouseEventArgs e)
        {
            DataWorker dataWorker = DataWorker.Instance;
            if (e.Button == MouseButtons.Left)
            {
                if (mailList.SelectedItems.Count > 0)
                {
                    mailText.Text = dataWorker.GetMails(currentFolder)[mailList.SelectedItems[0].Index].Body;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (currentFolder != "Sent Mail")
                    //проверяет что нажатие произведено в пределах выделенного элемента
                    if (mailList.FocusedItem.Bounds.Contains(e.Location))
                    {
                        var moveToItem = (ToolStripMenuItem)mailMenuStrip.Items[0];
                        //Если папок стало больше
                        if (moveToItem.DropDownItems.Count < dataWorker.GetFolders().Count - 2)
                        {
                            moveToItem.DropDownItems.Clear();
                            foreach (var folder in dataWorker.GetFolders())
                            {
                                if (folder != currentFolder && folder != "Sent Mail")
                                {
                                    /*var copyItem = new ToolStripMenuItem(folder);
                                    copyItem.Click += CopyMail;
                                    ((ToolStripMenuItem) mailMenuStrip.Items[0]).DropDownItems.Add(copyItem);*/

                                    var moveItem = new ToolStripMenuItem(folder);
                                    moveItem.Click += MoveMail;
                                    moveToItem.DropDownItems.Add(moveItem);
                                }
                            }
                        }
                        mailMenuStrip.Show(Cursor.Position);

                    }
            }
        }

        private void MoveMail(object sender, EventArgs e)
        {
            var dataWorker = DataWorker.Instance;
            var mail = dataWorker.GetMails(currentFolder)[mailList.FocusedItem.Index];
            dataWorker.DeleteMail(mail);
            mail.SetFolder(((ToolStripMenuItem)sender).Text);
            dataWorker.SendMail(mail);
            LoadMails(currentFolder);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new About();
            about.Show();
        }

        private void DeleteLetter_Click(object sender, EventArgs e)
        {
            DataWorker dataWorker = DataWorker.Instance;
            foreach (ListViewItem item in mailList.CheckedItems)
            {
                mailList.Items.Remove(item);
                dataWorker.DeleteMail(mails[item.Index]);
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataWorker.CurrentUser = null;
            var login = new LoginForm();
            Hide();
            login.ShowDialog();
            Close();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            DataWorker dataWorker = DataWorker.Instance;
            mailList.Items.Clear();
            mails.Clear();
            foreach (var item in dataWorker.GetMails(currentFolder))
            {
                mailList.Items.Add(new ListViewItem(new[] { item.From, item.Subject }));
                mails.Add(item);
            }
        }

        //Загрузка сообщений из файла и заполнение ими ListView
        private void LoadMails(string folderName)
        {
            DataWorker dataWorker = DataWorker.Instance;
            mailList.Items.Clear();
            mails.Clear();
            foreach (var item in dataWorker.GetMails(folderName))
            {
                mailList.Items.Add(new ListViewItem(new[] { item.From, item.To, item.Subject }));
                mails.Add(item);
            }
            mailList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            mailList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void deleteFolder_Click(object sender, EventArgs e)
        {
            Hide();
            var foldersManager = new FoldersManager();
            foldersManager.ShowDialog();
            Close();
        }

        private void openInWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var word = new Word.Application { Visible = true };
            word.Documents.Add();
            var mail = mails[mailList.FocusedItem.Index];

            var doc = word.Documents.get_Item(1);
            doc.Paragraphs[1].Range.Text = "From: " + mail.From + '\n';
            doc.Paragraphs[2].Range.Text = "To: " + mail.To + '\n';
            doc.Paragraphs[3].Range.Text = "Subject: " + mail.Subject + '\n';
            doc.Paragraphs[4].Range.Text = "Body: " + mail.Body + '\n';
        }

        private void openContactsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var excel = new Excel.Application
            {
                SheetsInNewWorkbook = 1
            };
            excel.Workbooks.Add();
            Excel.Worksheet table = excel.Workbooks[1].Worksheets.get_Item(1);
            DataWorker dataWorker = DataWorker.Instance;
            var contacts = dataWorker.GetContacts();
            table.Range["A1", "A1"].Value = "User name";
            table.Range["B1", "B1"].Value = "Login";
            for (int i = 2; i < contacts.Count + 2; i++)
            {
                table.Range["A" + i, "A" + i].Value = contacts.ElementAt(i - 2).Item1;
                table.Range["B" + i, "B" + i].Value = contacts.ElementAt(i - 2).Item2;
            }
            excel.Visible = true;
        }

        private void openContactsInWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataWorker dataWorker = DataWorker.Instance;
            var word = new Word.Application { Visible = true };
            var doc = word.Documents.Add();
            doc.Paragraphs[1].Range.Text = "Users table\n";
            var wdRange = doc.Paragraphs[2].Range;
            var contacts = dataWorker.GetContacts();
            var table = doc.Tables.Add(wdRange, contacts.Count + 1, 2);
            table.set_Style("Сетка таблицы");
            table.Cell(1, 1).Range.Text = "User name";
            table.Cell(1, 2).Range.Text = "Login";
            for (int i = 0; i < contacts.Count; i++)
            {
                table.Cell(i + 2, 1).Range.Text = contacts.ElementAt(i).Item1;
                table.Cell(i + 2, 2).Range.Text = contacts.ElementAt(i).Item2;
            }
            doc.Paragraphs[(contacts.Count + 1)*3 + 2].Range.Text = "Press Ctrl+P for print\n";
        }
    }

    public static class Dialog
    {
        public static bool isCanceled = true;
        public static string ShowDialog()
        {
            var dialog = new Form
            {
                Width = 280,
                Height = 120,
                Text = "Add folder"
            };
            var textLabel = new Label { Location = new Point(13, 13), Size = new Size(65, 13), Text = "Folder name" };
            var textBox = new TextBox { Location = new Point(84, 10), Size = new Size(160, 20) };
            var okButton = new Button { Text = "Add", Location = new Point(16, 42), Size = new Size(75, 23) };
            okButton.Click += (sender, e) =>
            {
                isCanceled = false;
                dialog.Close();
            };
            var cancelButton = new Button { Text = "Cancel", Location = new Point(166, 42), Size = new Size(75, 23) };
            cancelButton.Click += (sender, e) =>
            {
                isCanceled = true;
                dialog.Close();
            };

            dialog.Controls.Add(textLabel);
            dialog.Controls.Add(textBox);
            dialog.Controls.Add(okButton);
            dialog.Controls.Add(cancelButton);
            dialog.ShowDialog();

            return textBox.Text;
        }
    }
}