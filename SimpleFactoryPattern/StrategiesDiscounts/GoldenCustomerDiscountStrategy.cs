﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern.StrategiesDiscounts
{
    public class GoldenCustomerDiscountStrategy : ICustomerDiscountStrategy
    {
        public double ApplyDiscount(double totalPrice)
        {
            return totalPrice >= 10000 ?  0.1 : 0;
        }
    }
}
