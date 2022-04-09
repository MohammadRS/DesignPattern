namespace _10_Factory_Method.Sms;

public interface ISmsManager
{
    void Send(SmsDto dto);
}
public class SmsDto
{
    public string Reciver { get; set; }
    public string Sender { get; set; }
    public string Message { get; set; }
}