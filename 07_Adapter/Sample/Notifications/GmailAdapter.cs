namespace _07_Adapter.Sample.Notifications
{
    internal class GmailAdapter : ISendMessage
    {
        GmailServiceGoogle gmailService = new GmailServiceGoogle();
        public void Send(string Text)
        {
            gmailService.SendMail(Text);
        }
    }
}
