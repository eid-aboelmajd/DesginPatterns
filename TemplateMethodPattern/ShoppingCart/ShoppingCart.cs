using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethodPattern.Core;

namespace TemplateMethodPattern.ShoppingCart
{
    public abstract class ShoppingCart
    {
        public List<InvoiceLine> InvoiceLines = new();

        public void AddItem(int ItemId, int quantity, double unitPrice)
        {
            InvoiceLines.Add(new InvoiceLine { ItemId = ItemId, Quantity = quantity, Price = quantity * unitPrice });
        }

        public void Checkout(Customer customer)
        {
            var invoice = new Invoice
            {
                Customer = customer,
                InvoiceLines = InvoiceLines
            };

            ApplayTaxes(invoice);
            ApplayDiscount(invoice);
            ProcessPayment(invoice);
        }
        private void ApplayTaxes(Invoice invoice)
        {
            invoice.Taxes = invoice.TotalPrice * 0.15;
        }


        protected abstract void ApplayDiscount(Invoice invoice);

        private void ProcessPayment(Invoice invoice)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{GetType().Name} Invoice Create for custome `{invoice.Customer.Name}` with net price `{invoice.NetPrice}`");
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
