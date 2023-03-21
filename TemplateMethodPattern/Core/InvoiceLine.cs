using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.Core
{
    public class InvoiceLine
    {
        public int ItemId { get; set; }
        
        public double Quantity { get; set; }

        public double Price { get; set; }
    }
}
