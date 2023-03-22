using Sales.PaymentMethods.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesSystem.Payments
{
    internal class PayPalPaymentFactory : PaymentFactory
    {
        public override IPaymentMethod CreatePaymentMethod()
        {
            return new PayPalPaymentMethod();
        }
    }
}
