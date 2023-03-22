using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.PaymentMethods.Abstraction
{
    public abstract class PaymentFactory
    {
        public abstract IPaymentMethod CreatePaymentMethod();
    }
}
