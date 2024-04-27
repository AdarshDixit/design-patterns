namespace Builder
{
    /// <summary>
    /// Tea builder
    /// </summary>
    public class TeaBuilder : BeverageBuilder
    {
        public override void SetBeverageType()
        {
            Console.WriteLine("Set beverage type: TEA");
            ShowBeverage().BeverageName = "TEA";
        }

        public override void SetMilkQuantity()
        {
            Console.WriteLine("Set milk quantity: 100ml");
            ShowBeverage().MilkQuantity = 100;
        }

        public override void SetPowderType()
        {
            Console.WriteLine("Set powder type: TEA powder");
            ShowBeverage().PowderType = "TEA Powder";
        }

        public override void SetSugarQuantity()
        {
            Console.WriteLine("Set sugar quantity: 5gms");
            ShowBeverage().SugarQuantity = 5;
        }

        public override void SetWaterQuantity()
        {
            Console.WriteLine("Set water quantity: 100ml");
            ShowBeverage().WaterQuantity = 100;
        }
    }
}
