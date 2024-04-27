namespace FactoryPattern
{
    public class PlatinumCreditCard : ICreditCard
    {
        public int GetAnnualCharge()
        {
            Console.WriteLine("Moneyback annual charge: 200");
            return 200;
        }

        public string GetCardType()
        {
            Console.WriteLine("Moneyback card type: Platinum");
            return "Platinum";
        }

        public int GetCreditLimit()
        {
            Console.WriteLine("Moneyback credit limit: 50000");
            return 50000;
        }
    }
}
