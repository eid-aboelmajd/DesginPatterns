using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.Core
{
    public class ItemDataReader
    {
        public List<Item> GetInvoiceLines() 
        {
            return new List<Item> {
                new Item
                {
                Id = 1,
                Name = "Test1",
                UnitPrice = 1500
                } ,
                new Item
                {
                Id = 2,
                Name = "Test2",
                UnitPrice = 1500
                },new Item
                {
                Id = 3,
                Name = "Test3",
                UnitPrice = 1500
                }
            };
        }
    }
}
