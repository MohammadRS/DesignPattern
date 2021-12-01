using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Decorator
{
    public class SendEmail
    {
        public void Send()
        {
            Console.WriteLine("Email Sended......!");
        }
    }

    public class SendEmailDecorator : SendEmail
    {
        private readonly SendEmail _sendEmail;
        public SendEmailDecorator(SendEmail sendEmail)
        {
            _sendEmail = sendEmail;
        }

        public void Send()
        {
            _sendEmail.Send();
            Log();
        }

        public void Log()
        {
            Console.WriteLine("Log");
        }
    }
}
