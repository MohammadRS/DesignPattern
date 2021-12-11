using System.Configuration;

namespace _03_Bridge.MailService
{
    public static class Implementation
    {
        public static IMailServiceImplementor GetImplementor()
        {
            //string service = "yahoo";
            //if (service == "gmail")
            //{
            //    return new GmailService();
            //}
            //else if (service == "yahoo")
            //{
            //    return new YahooService();
            //}
            //return new MyCompanyMailService();

            var config = ConfigurationManager.AppSettings;
            if (config["EmailImplementor"] == "Gmail")
            {
                return new GmailService();
            }
            else if (config["EmailImplementor"] == "Yahoo")
            {
                return new YahooService();
            }
            else
            {
                return new CompaniService();
            }
        }
    }
}
