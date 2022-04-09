using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Factory_Method.Sms.Twilio
{
    public class TwilioSmsManager : ISmsManager
    {
        public void Send(SmsDto sms)
        {
            Console.WriteLine("Send Sms  With TwilioSmsManager..........");
            //send sms
        }
    }
}
