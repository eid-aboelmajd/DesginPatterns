// See https://aka.ms/new-console-template for more information
using StrategyPattern.Core;
using StrategyPattern.StrategiesDiscounts;
using System.Net.Http.Headers;

Console.WriteLine("Hello, World!");

CustomerReader customerReader = new CustomerReader();

var customers = customerReader.GetCustomers();

while (true)
{
    Console.WriteLine($"Enter [1] to choose the first user , [2] to choose the second one ..");

    int customerId = int.Parse(Console.ReadLine());

    var customer = customers.FirstOrDefault(x => x.Id == customerId);

    Console.WriteLine($"Customer Name = {customer.Name}");

    Console.WriteLine("Enter The Quntity : ");

    double quantity = double.Parse(Console.ReadLine());

    Console.WriteLine("Enter The Price : ");

    double price = double.Parse(Console.ReadLine());

    ICustomerDiscountStrategy customerDiscountStrategy = null;

    switch (customer.CustomerCategory)      
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
        default:
            customerDiscountStrategy = new NewCustomerDiscountStrategy();
            break;
    }

    InvoiceManager invoiceManager = new InvoiceManager(customerDiscountStrategy);

    var invoice = invoiceManager.CreateInvoice(customer, quantity, price);

    Console.WriteLine($"The Net Price of that invoice is {invoice.NetPrice}");
    Console.WriteLine("-----------------------------------------------------");
}