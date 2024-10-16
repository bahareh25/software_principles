namespace Session11.Solid.OCP
{
    public class BolooriCalculator : CalculateFinalPrice
    {
        public override int Calculate(int price)
        {
            return price - 50;
        }
    }
}
