using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class PayItemAdapter
    {
        private readonly PayItem _payItem;

        public PayItemAdapter(PayItem payItem)
        {
            _payItem = payItem;
        }


        public string Name => _payItem.Name;

        public decimal Value => _payItem.HasComesion ? _payItem.Value * 1.5m : _payItem.Value;
    }
}
