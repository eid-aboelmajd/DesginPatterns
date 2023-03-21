using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethodPattern.Core;

namespace TemplateMethodPattern.ShoppingCart
{
    public class StoreShoppingCart : ShoppingCart
    {
        protected override void ApplayDiscount(Invoice invoice)
        {
            invoice.DiscountPercentage = 0;
        }
    }
}
