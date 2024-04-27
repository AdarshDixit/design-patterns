namespace Builder
{
    /// <summary>
    /// Beverage base implementation
    /// </summary>
    public class Beverage
    {
        public int WaterQuantity  { get; set; }
        public int MilkQuantity  { get; set; }
        public int SugarQuantity  { get; set; }
        public string PowderType { get; set; }
        public string BeverageName { get; set; }


        public string GetBeverage()
        {
            return $"Hot beverage {BeverageName} made by adding {WaterQuantity}ml water, {MilkQuantity} ml milk, {SugarQuantity}gms sugar, {PowderType} powder.";
        }
    }
}
