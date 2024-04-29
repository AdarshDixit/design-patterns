// See https://aka.ms/new-console-template for more information
using FactoryMethodPattern;

Console.WriteLine("Hello, World!");

NotificationService.Notify(new EmailNotifierFactory(), "email 123");
NotificationService.Notify(new SMSNotifierFactory(), "sms 123");
