using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _01_Decorator.WebClient_Decorator
{
    public class WebClientDecorator : WebClient
    {
        private readonly WebClient _client;
        public WebClientDecorator(WebClient webClient)
        {
            _client = webClient;
        }

        public string DownloadString(string address)
        {
            if (address.StartsWith("https://bugeto.net"))
            {
                return _client.DownloadString(address);

            }
            else
            {
                return string.Empty;
            }
        }
    }
}
