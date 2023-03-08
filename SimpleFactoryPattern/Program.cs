

using SimpleFactoryPattern.Core;
using SimpleFactoryPattern.StrategiesDiscounts;

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

    ICustomerDiscountStrategy customerDiscountStrategy = new CustomerDiscountStrategyFactory().CreateCustomerDiscountStrategy(customer.CustomerCategory);

    InvoiceManager invoiceManager = new InvoiceManager(customerDiscountStrategy);

    var invoice = invoiceManager.CreateInvoice(customer, quantity, price);

    Console.WriteLine($"The Net Price of that invoice is {invoice.NetPrice}");
    Console.WriteLine("-----------------------------------------------------");
}