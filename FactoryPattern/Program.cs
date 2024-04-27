// See https://aka.ms/new-console-template for more information
using FactoryPattern;

var factory = new CreditCardFactory();
var creditCard = factory.GetCreditCard("platinum");
Console.WriteLine($"Credit card: {creditCard.GetCardType()} - Annual charge: {creditCard.GetAnnualCharge()} - Limit: {creditCard.GetCreditLimit()}");