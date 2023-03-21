using TemplateMethodPattern.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.StrategiesDiscounts
{
    public class InvoiceManager
    {
        private readonly ICustomerDiscountStrategy _cutomerDistountStrategy;

        public InvoiceManager(ICustomerDiscountStrategy customerDiscountStrategy)
        {
            _cutomerDistountStrategy = customerDiscountStrategy;
        }

        public Invoice CreateInvoice(Customer customer , double quantity , double price) {

            var invoice = new Invoice()
            {
                Customer = customer,
                InvoiceLines = new List<InvoiceLine>() {
                    new InvoiceLine() {
                        Quantity = quantity,
                        Price = price
                    }
                }
            };

            invoice.DiscountPercentage = _cutomerDistountStrategy.ApplyDiscount(invoice.TotalPrice);

            return invoice;
        }
    }
}
