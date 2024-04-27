namespace Builder
{
    /// <summary>
    /// Director to direct the builder steps sequence
    /// </summary>
    public class BeverageDirector
    {
        public Beverage MakeBeverage(BeverageBuilder beverageBuilder)
        { 
            // creates base builder object
            beverageBuilder.CreateBeverage();

            // setup sequence/order of execution
            beverageBuilder.SetBeverageType();
            beverageBuilder.SetWaterQuantity();
            beverageBuilder.SetMilkQuantity();
            beverageBuilder.SetSugarQuantity();
            beverageBuilder.SetPowderType();

            // get base builder object
            return beverageBuilder.ShowBeverage();
        }
    }
}
