using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern.StrategiesDiscounts
{
    public class NewCustomerDiscountStrategy : ICustomerDiscountStrategy
    {
        public double ApplyDiscount(double totalPrice)
        {
            return 0;
        }
    }
}
