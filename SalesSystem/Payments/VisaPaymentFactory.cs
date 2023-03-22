using Sales.PaymentMethods.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesSystem.Payments
{
    internal class VisaPaymentFactory : PaymentFactory
    {
        public override IPaymentMethod CreatePaymentMethod()
        {
            return new VisaPaymentMethod();
        }
    }
}
