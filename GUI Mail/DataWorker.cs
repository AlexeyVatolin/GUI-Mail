using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;

namespace GUI_Mail
{
    class DataWorker
    {
        private static readonly Lazy<DataWorker> lazy =
        new Lazy<DataWorker>(() => new DataWorker());

        public static User CurrentUser;

        private List<User> users;
        private List<Mail> mails;
        private List<string> folders;

        private string usersFileName = "users.db";
        private string mailsFileName = "mails.db";
        private string foldersFileName => CurrentUser.Login + "_folders.db";

        public static DataWorker Instance => lazy.Value;

        private DataWorker()
        {
            var usersObjects = ReadObjects(usersFileName);
            if (usersObjects is List<User>)
            {
                users = (List<User>)usersObjects;
            }
            else
            {
                users = new List<User>();
            }

            var mailsObjects = ReadObjects(mailsFileName);
            if (mailsObjects is List<Mail>)
            {
                mails = (List<Mail>)mailsObjects;
            }
            else
            {
                mails = new List<Mail>();
            }

            CurrentUser = null;
        }


        /*******************
         * Functions for users
         ******************/

        public void AddUser(User user)
        {
            if (user.Login == "Lexa")
            {
                user.IsAdmin = true;
                CurrentUser = user;
            }
            users.Add(user);
            SaveObjects(usersFileName, users);
        }

        public List<User> GetUsers()
        {
            return users;
        }

        public void DeleteUser(string login)
        {
            var user = users.Find(u => u.Login == login);
            if (user != null)
            {
                users.Remove(user);
                SaveObjects(usersFileName, users);
            }
        }

        public void ChangeAdminState(string login)
        {
            var user = users.Find(u => u.Login == login);
            if (user != null)
            {
                if (users[users.IndexOf(user)].IsAdmin)
                    users[users.IndexOf(user)].IsAdmin = false;
                else
                    users[users.IndexOf(user)].IsAdmin = true;
                SaveObjects(usersFileName, users);
            }
        }

        public void EditUserData(string username, string password)
        {
            var userIndex = users.FindIndex(u => u.Login == CurrentUser.Login);
            users[userIndex].ChangeUsernameAndPassword(username, password);
            SaveObjects(usersFileName, users);
        }

        public void ChangeSignature(string signature)
        {
            var userIndex = users.FindIndex(u => u.Login == CurrentUser.Login);
            users[userIndex].ChangeSignature(signature);
            SaveObjects(usersFileName, users);
        }

        public void ChangeTheme(string theme)
        {
            var userIndex = users.FindIndex(u => u.Login == CurrentUser.Login);
            users[userIndex].ChangeTheme(theme);
            SaveObjects(usersFileName, users);
        }

        //Проверка существования логина для регистрации
        public bool LoginExist(string login)
        {
            if (users.Count(user => user.Login == login) > 0)
            {
                return true;
            }
            return false;
        }

        //Выделение логина из адреса почты
        public string SelectLogin(string mailAddres)
        {
            return mailAddres.Substring(0, mailAddres.IndexOf('@'));
        }

        //Логин с проверками
        public LoginErrors Login(string login, string password)
        {
            var user = users.Find(u => u.Login == login);
            if (user == null)
            {
                return LoginErrors.UsernameNotExist;
            }
            if (GetMd5Hash(password) != user.Password)
            {
                return LoginErrors.PasswordNotCorrect;
            }
            CurrentUser = user;
            return LoginErrors.Nothing;
        }

        //Шифрование текста в MD5
        public string GetMd5Hash(string input)
        {
            StringBuilder sBuilder = new StringBuilder();
            using (MD5 md5Hash = MD5.Create())
            {
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }
            }

            return sBuilder.ToString();
        }

        /*******************
         * Functions for mails
         ******************/

        public List<Mail> GetMails(string folderName)
        {
            var mailsObjects = ReadObjects(mailsFileName);
            if (mailsObjects is List<Mail>)
            {
                mails = (List<Mail>)mailsObjects;
            }
            if (folderName == "Sent Mail" || folderName == "Drafts")
            {
                return
                    mails.Where(mail => mail.From == CurrentUser.Login + "@mymail.com")
                        .ToList();
            }
            return
                mails.Where(mail => mail.To == CurrentUser.Login + "@mymail.com" && mail.Folder == folderName).ToList();
        }

        public void SendMail(Mail mail)
        {
            mails.Add(mail);
            SaveObjects(mailsFileName, mails);
        }

        public void DeleteMail(Mail mail)
        {
            mails.Remove(mail);
            SaveObjects(mailsFileName, mails);
        }

        /*******************
         * Functions for folders
         ******************/

        public List<string> GetFolders()
        {
            if (folders == null)
            {
                var foldersObjects = ReadObjects(foldersFileName);
                if (foldersObjects is List<string>)
                {
                    folders = (List<string>)foldersObjects;
                }
            }
            if (folders == null)
            {
                folders = new List<string>();
                AddFolder("Inbox");
                AddFolder("Drafts");
                AddFolder("Sent Mail");
                AddFolder("Spam");
            }

            return folders;
        }

        public bool AddFolder(string folderName)
        {
            if (folders.Contains(folderName))
            {
                return false;
            }
            folders.Add(folderName);
            SaveObjects(foldersFileName, folders);
            return true;
        }

        public void DeleteFolder(string folderName)
        {
            folders.Remove(folderName);
            SaveObjects(foldersFileName, folders);

            mails.RemoveAll(mail => mail.To == CurrentUser.Login + "@mymail.com" && mail.Folder == folderName);
            SaveObjects(mailsFileName, mails);
        }

        /*******************
         * Functions for contacts
         ******************/

        public HashSet<Tuple<string, string>> GetContacts()
        {
            var contacts = new HashSet<Tuple<string, string>>();
            foreach (var mail in mails)
            {
                if (mail.From == CurrentUser.Login + "@mymail.com")
                {
                    contacts.Add(new Tuple<string, string>(users.First(user => user.Login == SelectLogin(mail.To)).Login, mail.To));
                }
                if (mail.To == CurrentUser.Login + "@mymail.com")
                {
                    contacts.Add(new Tuple<string, string>(users.First(user => user.Login == SelectLogin(mail.From)).Login, mail.From));
                }
            }
            return contacts;
        }

        //Считывание сериализованных объектов из файла
        private object ReadObjects(string fileName)
        {
            object serilizedObject = null;
            using (var fstream = File.Open(fileName, FileMode.OpenOrCreate))
            {
                if (fstream.Length != 0)
                {
                    var binaryFormatter = new BinaryFormatter();
                    serilizedObject = binaryFormatter.Deserialize(fstream);
                }
            }
            return serilizedObject;
        }

        //Сохрание сериализованных объектов в файла
        private void SaveObjects(string fileName, object objectToSerialize)
        {
            using (var fstream = File.Open(fileName, FileMode.Create))
            {
                var binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fstream, objectToSerialize);
            }
        }

        //Перечисление для функции Login
        public enum LoginErrors
        {
            UsernameNotExist, PasswordNotCorrect, Nothing
        }
    }


}
