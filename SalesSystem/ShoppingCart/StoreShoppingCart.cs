using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesSystem.Core;

namespace SalesSystem.ShoppingCart
{
    public class StoreShoppingCart : ShoppingCart
    {
        protected override void ApplayDiscount(Invoice invoice)
        {
            invoice.DiscountPercentage = 0;
        }
    }
}
