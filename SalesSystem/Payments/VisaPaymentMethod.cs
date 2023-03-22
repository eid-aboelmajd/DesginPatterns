using Sales.PaymentMethods.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesSystem.Payments
{
    public class VisaPaymentMethod : IPaymentMethod
    {
        public Payment Charge(int customerId, double chargedAmount)
        {
            var commsion = chargedAmount >= 10000 ? chargedAmount * 0.02 : 0;

            return new Payment {
                CustomerId = customerId,
                ReferenceNumber = new Guid(),
                AmountCharged = chargedAmount + commsion,
            };
        }
    }
}
