using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NULLObjectPattern.StrategiesDiscounts
{
    public class NewCustomerDiscountStrategy : ICustomerDiscountStrategy
    {
        public double ApplyDiscount(double totalPrice)
        {
            return 0;
        }
    }
}
