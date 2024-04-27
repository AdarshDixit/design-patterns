namespace FactoryPattern
{
    public class MoneybackCreditCard : ICreditCard
    {
        public int GetAnnualCharge()
        {
            Console.WriteLine("Moneyback annual charge: 100");
            return 100;
        }

        public string GetCardType()
        {
            Console.WriteLine("Moneyback card type: Moneyback");
            return "Moneyback";
        }

        public int GetCreditLimit()
        {
            Console.WriteLine("Moneyback credit limit: 15000");
            return 15000;
        }
    }
}
