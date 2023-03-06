using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class EmployeeAdapter
    {
        private readonly Employee _employee;
        private readonly IEnumerable<PayItemAdapter> _payItemAdapters;

        public EmployeeAdapter(Employee employee)
        {
            this._employee = employee;
            _payItemAdapters = employee.PayItems.Select(x => new PayItemAdapter(x));
        }

        public string FullName => $"{_employee.FirstName} {_employee.SecondName} {_employee.ThirdName}";

        public IEnumerable<PayItemAdapter> PayItems => _payItemAdapters;
    }
}
