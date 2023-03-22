using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sales.PaymentMethods.Abstraction;
using SalesSystem.Core;

namespace SalesSystem.ShoppingCart
{
    public abstract class ShoppingCart
    {
        public List<InvoiceLine> InvoiceLines = new();

        public void AddItem(int ItemId, int quantity, double unitPrice)
        {
            InvoiceLines.Add(new InvoiceLine { ItemId = ItemId, Quantity = quantity, Price = quantity * unitPrice });
        }

        public void Checkout(Customer customer , PaymentFactory paymentProcessor)
        {
            var invoice = new Invoice
            {
                Customer = customer,
                InvoiceLines = InvoiceLines
            };

            ApplayTaxes(invoice);
            ApplayDiscount(invoice);
            ProcessPayment(invoice , paymentProcessor);
        }
        private void ApplayTaxes(Invoice invoice)
        {
            invoice.Taxes = invoice.TotalPrice * 0.15;
        }


        protected abstract void ApplayDiscount(Invoice invoice);

        private void ProcessPayment(Invoice invoice, PaymentFactory paymentProcessor)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            var paymentmethod = paymentProcessor.CreatePaymentMethod();
            var payment = paymentmethod.Charge(invoice.Customer.Id, invoice.NetPrice);

            Console.WriteLine($"{GetType().Name} Invoice Create for custome `{invoice.Customer.Name}` with net price `{invoice.NetPrice}`");
            Console.WriteLine($"we will be charged with {paymentProcessor.GetType().Name} by {payment.AmountCharged}");
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
