namespace Session11.Solid.OCP
{
    public class SilverCalculator : CalculateFinalPrice

    {
        public override int Calculate(int price)
        {
            return price - 10;
        }
    }
}
