namespace Session11.Solid.OCP
{
    public class GoldCalculator : CalculateFinalPrice
    {
        public override int Calculate(int price)
        {
            return price - 20;
        }
    }
}
