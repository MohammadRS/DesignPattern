using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Bridge.MailService
{
    public interface IMailServiceImplementor
    {
        void SendEmail(string Reciver, string Title, string Message);
    }

    public class GmailService : IMailServiceImplementor
    {
        public void SendEmail(string Reciver, string Title, string Message)
        {
            throw new NotImplementedException();
        }
    }

    public class YahooService : IMailServiceImplementor
    {
        public void SendEmail(string Reciver, string Title, string Message)
        {
            throw new NotImplementedException();
        }
    }

    public class CompaniService : IMailServiceImplementor
    {
        public void SendEmail(string Reciver, string Title, string Message)
        {
            throw new NotImplementedException();
        }
    }
}
