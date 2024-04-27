namespace Builder
{
    /// <summary>
    /// This is abstract builder which will act as Base of concrete beverage builders
    /// </summary>
    public abstract class BeverageBuilder
    {
        protected Beverage beverage;
        public void CreateBeverage()
        {
            beverage = new Beverage();
        }

        public Beverage ShowBeverage()
        {
            return beverage;
        }

        public abstract void SetBeverageType();
        public abstract void SetWaterQuantity();
        public abstract void SetMilkQuantity();
        public abstract void SetSugarQuantity();
        public abstract void SetPowderType();
    }
}
