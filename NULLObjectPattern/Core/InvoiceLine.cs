﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NULLObjectPattern.Core
{
    public class InvoiceLine
    {
        public int Id { get; set; }
        public string Name { get; set; }     

        public double Quantity { get; set; }

        public double Price { get; set; }

    }
}
