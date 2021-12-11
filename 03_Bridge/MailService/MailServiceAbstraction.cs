using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Bridge.MailService
{
    public abstract class MailServiceAbstraction
    {
        private IMailServiceImplementor _implementor;
        public MailServiceAbstraction()
        {
            _implementor = Implementation.GetImplementor();
        }

        public virtual void Send(EmailInformationDto email)
        {
            _implementor.SendEmail(email.Reciver, email.Title, email.Message);
        }
    }

    public class RefinedMailService : MailServiceAbstraction
    {

    }

    public class EmailInformationDto
    {
        public string Reciver { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
    }
}
