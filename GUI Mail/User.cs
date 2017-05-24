using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Mail
{
    [Serializable]
    class User
    {
        public string Username { get; private set; }
        public string Login { get; }
        public string Password { get; private set; }
        public bool IsAdmin { get; internal set; }
        public string Signature { get; private set; }

        public User(string username, string login, string password, bool isAdmin = false)
        {
            var dataWorker = DataWorker.Instance;
            Username = username;
            Login = login;
            Password = dataWorker.GetMd5Hash(password);
            IsAdmin = isAdmin;
            Signature = "With best whishes,\nI love you!";
        }

        public void ChangeUsernameAndPassword(string username, string password)
        {
            Username = username;
            var dataWorker = DataWorker.Instance;
            Password = dataWorker.GetMd5Hash(password);
        }

        public void ChangeSignature(string signature)
        {
            Signature = signature;
        }
    }
}
