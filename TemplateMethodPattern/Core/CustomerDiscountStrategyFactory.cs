using TemplateMethodPattern.StrategiesDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.Core
{
    public class CustomerDiscountStrategyFactory
    {
        public ICustomerDiscountStrategy CreateCustomerDiscountStrategy(CustomerCategory customerCategory) 
        {
            ICustomerDiscountStrategy customerDiscountStrategy = null;
            switch (customerCategory)
            {
                case CustomerCategory.New:
                    customerDiscountStrategy = new NewCustomerDiscountStrategy();
                    break;
                case CustomerCategory.Silver:
                    customerDiscountStrategy = new SilverCustomerDiscountStrategy();
                    break;
                case CustomerCategory.Golden:
                    customerDiscountStrategy = new GoldenCustomerDiscountStrategy();
                    break;    
                    default: return new NullCustomerDiscountStrategy();
            }
            return customerDiscountStrategy;
        }
    }
}
