using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Adapter.Sample.Notifications
{
    internal class Whatsapp : ISendMessage
    {
        public void Send(string Text)
        {
            Console.WriteLine("Whatsapp");
        }
    }
}
