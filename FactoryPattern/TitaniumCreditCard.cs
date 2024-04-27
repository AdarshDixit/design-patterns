namespace FactoryPattern
{
    public class TitaniumCreditCard : ICreditCard
    {
        public int GetAnnualCharge()
        {
            Console.WriteLine("Moneyback annual charge: 300");
            return 300;
        }

        public string GetCardType()
        {
            Console.WriteLine("Moneyback card type: Titanium");
            return "Titanium";
        }

        public int GetCreditLimit()
        {
            Console.WriteLine("Moneyback credit limit: 75000");
            return 75000;
        }
    }
}
