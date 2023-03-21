using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethodPattern.Core;

namespace TemplateMethodPattern.ShoppingCart
{
    public class OnlineShoppingCart : ShoppingCart
    {
        protected override void ApplayDiscount(Invoice invoice)
        {
            if(invoice.TotalPrice >= 10000)
                invoice.DiscountPercentage = 0.05;
        }
    }
}
