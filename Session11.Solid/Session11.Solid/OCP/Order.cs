using System;
using System.Collections.Generic;
using System.Text;

namespace Session11.Solid.OCP
{

    public abstract class CalculateFinalPrice
    {
        public abstract int Calculate(int price);
    }
    public class Order
    {
        private CalculateFinalPrice _finalPriceCalculateor;
        public Order(CalculateFinalPrice finalPriceCalculateor)
        {
            _finalPriceCalculateor = finalPriceCalculateor;
        }
        public int TotalValue { get; set; }
        public DateTime OrderDate { get; set; }
        public Customer Customer { get; set; }

        public int GetFinalValue()
        {
            int finalValue = _finalPriceCalculateor.Calculate(TotalValue);
            //switch (Customer.CustomerType)
            //{
            //    case CustomerType.Usual:
            //        finalValue -= 50;
            //        break;
            //    case CustomerType.Silver:
            //        finalValue -= 10;
            //        break;
            //    case CustomerType.Gold:
            //        finalValue -= 20;

            //        break;
            //}
            return TotalValue;
        }
    }
}
