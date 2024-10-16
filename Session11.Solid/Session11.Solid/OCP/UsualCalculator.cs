namespace Session11.Solid.OCP
{
    public class UsualCalculator : CalculateFinalPrice
    {
        public override int Calculate(int price)
        {
            return price;
        }
    }
}
