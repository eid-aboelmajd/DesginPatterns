using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.Core
{
    public class CustomerReader
    {
        public List<Customer> GetCustomers()
        {
            return new List<Customer>()
            {
                new Customer
                {
                    Id= 1,
                    Name = "Eid Mosad El-sayed",
                    CustomerCategory = CustomerCategory.Silver
                },
                new Customer
                {
                    Id=2,
                    Name="Aya Essam",
                    CustomerCategory = CustomerCategory.Golden
                },
                new Customer
                {
                    Id=3,
                    Name="albaraa eid",
                    CustomerCategory = CustomerCategory.None
                }
            };
        }
    }
}
