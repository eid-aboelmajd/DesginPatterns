using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.PaymentMethods.Abstraction
{
    public interface IPaymentMethod
    {
        Payment Charge(int customerId , double chargedAmount);
    }
}
