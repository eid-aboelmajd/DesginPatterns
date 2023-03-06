using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class EmployeeDataReader
    {
        public List<Employee> LoadEmployees()
        {
            return new List<Employee>() 
            {
                new Employee
                {
                    FirstName = "eid",
                    SecondName = "mosad",
                    ThirdName = " elsayed",
                    PayItems = new List<PayItem>()
                    {
                        new PayItem 
                        {
                            Name = "Basic",
                            Value = 2500m
                        } ,
                    }
                } ,
                new Employee
                {
                    FirstName = "ahmed",
                    SecondName = "mohaed",
                    ThirdName = " ahmed",
                    PayItems = new List<PayItem>()
                    {
                        new PayItem 
                        {
                            Name = "Basic",
                            Value = 2500m
                        } ,
                    } 
                } ,
                new Employee
                {
                    FirstName = "aya",
                    SecondName = "mosad",
                    ThirdName = " essam",
                    PayItems = new List<PayItem>()
                    {
                        new PayItem 
                        {
                            Name = "Basic",
                            Value = 2500m
                        } ,
                    } 
                }
            };
        }
    }
}
