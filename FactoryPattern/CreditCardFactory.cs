namespace FactoryPattern
{
    public class CreditCardFactory
    {
        public ICreditCard GetCreditCard(string cardType) 
        {
            return cardType.ToLowerInvariant() switch
            {
                "moneyback" => new MoneybackCreditCard(),
                "platinum" => new PlatinumCreditCard(),
                "titanium" => new TitaniumCreditCard(),
                _ => throw new Exception("Invalid credit card"),
            };
        } 
    }
}
