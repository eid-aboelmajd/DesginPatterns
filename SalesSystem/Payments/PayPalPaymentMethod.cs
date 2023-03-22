using Sales.PaymentMethods.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesSystem.Payments
{
    internal class PayPalPaymentMethod : IPaymentMethod
    {
        public Payment Charge(int customerId, double chargedAmount)
        {
            return new Payment
            {
                CustomerId = customerId,
                ReferenceNumber = new Guid(),
                AmountCharged = chargedAmount + chargedAmount * 0.05,
            };
        }
    }
}
