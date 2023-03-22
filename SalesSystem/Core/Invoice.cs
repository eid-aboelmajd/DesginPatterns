using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesSystem.Core
{
    public class Invoice
    {
        public Customer Customer { get; set; }

        public IEnumerable<InvoiceLine> InvoiceLines { get; set; }

        public double TotalPrice => InvoiceLines.Sum(x => x.Price);

        public double DiscountPercentage { get; set; }

        public double Taxes { get; set; }

        public double NetPrice => TotalPrice + Taxes - (TotalPrice * DiscountPercentage);
    }
}
