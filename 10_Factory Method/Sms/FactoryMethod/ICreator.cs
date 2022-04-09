using _10_Factory_Method.Sms.Kavenegar;
using _10_Factory_Method.Sms.Twilio;

namespace _10_Factory_Method.Sms.FactoryMethod
{
    public interface ICreator
    {
        ISmsManager FacatoryMethod();
    }

    public class Creator : ICreator
    {
        public ISmsManager FacatoryMethod()
        {
            string config = "Kavenegar";

            if (config == "Twilio")
            {
                return new TwilioSmsManager();
            }
            else
            {
                return new KavenegarSmsManager();
            }
        }
    }
}
