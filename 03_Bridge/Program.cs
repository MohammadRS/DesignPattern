using _03_Bridge.Bridge.Abstractions;
using _03_Bridge.MailService;

RefindAbstraction refind = new RefindAbstraction();
refind.Function();

RefinedMailService mailService = new RefinedMailService();
mailService.Send(new EmailInformationDto
{
    Message = "this is a message from my app ",
    Reciver = "bugeto@gmail.com",
    Title = "Alert mail"
});

Console.ReadLine();
