namespace Builder
{
    /// <summary>
    /// Coffee builder
    /// </summary>
    public class CoffeeBuilder : BeverageBuilder
    {
        public override void SetBeverageType()
        {
            Console.WriteLine("Set beverage type: COFFEE");
            ShowBeverage().BeverageName = "COFFEE";
        }

        public override void SetMilkQuantity()
        {
            Console.WriteLine("Set milk quantity: 100ml");
            ShowBeverage().MilkQuantity = 100;
        }

        public override void SetPowderType()
        {
            Console.WriteLine("Set powder type: COFFEE powder");
            ShowBeverage().PowderType = "COFFEE Powder";
        }

        public override void SetSugarQuantity()
        {
            Console.WriteLine("Set sugar quantity: 5gms");
            ShowBeverage().SugarQuantity = 5;
        }

        public override void SetWaterQuantity()
        {
            Console.WriteLine("Set water quantity: 50ml");
            ShowBeverage().WaterQuantity = 100;
        }
    }
}
