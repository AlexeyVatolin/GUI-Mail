using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Mail
{
    [Serializable]
    class Mail
    {
        public string From { get; }
        public string To { get; }
        public string Subject { get; }
        public string Body { get; }
        public string Folder { get; private set; }
        //public string Id { get; }

        public Mail(string from, string to, string subject, string body, string folder)
        {
            From = from;
            To = to;
            Subject = subject;
            Body = body;
            Folder = folder;
            //Id = Guid.NewGuid().ToString();
        }

        public void SetFolder(string folder)
        {
            Folder = folder;
        }
    }
}
