using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.StrategiesDiscounts
{
    public interface ICustomerDiscountStrategy
    {
        double ApplyDiscount(double totalPrice);
    }
}
