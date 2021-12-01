// See https://aka.ms/new-console-template for more information
using _01_Decorator;
using _01_Decorator.WebClient_Decorator;
using System.Net;

ConcretcComponent component = new ConcretcComponent();
ConcretcDecorator concreateDecorator = new ConcretcDecorator(component);
concreateDecorator.Operation();

SendEmail sendEmail = new SendEmail();
SendEmailDecorator emailDecorator = new SendEmailDecorator(sendEmail);
emailDecorator.Send();

WebClient webClient = new WebClient();
WebClientDecorator WebClient = new WebClientDecorator(webClient);

Console.ReadLine();
