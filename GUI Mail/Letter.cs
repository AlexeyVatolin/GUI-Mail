using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Mail
{
    class Letter
    {
        public string from;
        public string to;
        public string subject;
        public string body;

        public Letter(string from, string to, string subject, string body)
        {
            this.from = from;
            this.to = to;
            this.subject = subject;
            this.body = body;
        }
    }
}
