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

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            var mail = obj as Mail;
            if (mail != null)
            {
                if (From == mail.From && To == mail.To && Subject == mail.Subject && Body == mail.Body &&
                    Folder == mail.Folder)
                {
                    return true;
                }
            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

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
