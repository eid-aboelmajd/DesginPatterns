// See https://aka.ms/new-console-template for more information
using TemplateMethodPattern.Core;
using TemplateMethodPattern.ShoppingCart;

Console.WriteLine("Hello, World!");

while (true)
{
    var customers = new CustomerReader().GetCustomers();

    var items = new ItemDataReader().GetInvoiceLines();

    Console.WriteLine("customers List");

    foreach (var item in customers)
    {
        Console.WriteLine($"{item.Id} - {item.Name}");
    }

    Console.WriteLine("Item List");

    foreach (var item in items)
    {
        Console.WriteLine($"{item.Id} - Nam : {item.Name} , unit Price {item.UnitPrice}");
    }


    Console.WriteLine("Enter Customer Id :");
    int customerId = int.Parse(Console.ReadLine());

    var customer = customers.FirstOrDefault(x => x.Id == customerId);

    Console.WriteLine("Please Enter `1` for online shopping cart and `2` for In store shopping cart");
    int cartType = int.Parse(Console.ReadLine());

    ShoppingCart cart = cartType == 1 ? new OnlineShoppingCart() : new StoreShoppingCart();
    while (true)
    {
        Console.WriteLine("Enter Item Id (0 to stop Order)");

        int itemId = int.Parse(Console.ReadLine());
        if (itemId == 0)
            break;

        Item item = items.FirstOrDefault(x => x.Id == itemId);

        Console.WriteLine("Enter Quantity : ");
        int quantity = int.Parse(Console.ReadLine());

        cart.AddItem(itemId, quantity, item.UnitPrice);
    }

    cart.Checkout(customer);

    Console.WriteLine("Press any key to start another invoice");
    Console.ReadKey();
    Console.WriteLine("----------------------------------------");
}



