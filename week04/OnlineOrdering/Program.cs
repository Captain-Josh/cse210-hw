using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
         Address address1 = new Address("123 Main St", "New York", "NY", "USA");
         Customer customer1 = new Customer("David Nweke", address1);
         Order order1 = new Order(customer1);
         order1.AddProduct(new Product("Laptop","P100", 800, 1));
         order1.AddProduct(new Product("Mouse","P101", 20, 2));
         order1.AddProduct(new Product("Keyboard","P102", 50, 1));

         Address address2 = new Address("45 King Rd", "London", "London", "UK");
         Customer customer2 = new Customer("Joshua Nweke", address2);
         Order order2 = new Order(customer2);
         order2.AddProduct(new Product("Phone","P201", 500, 1));
         order2.AddProduct(new Product("Charger","P200", 20, 2));

         Console.WriteLine(order1.GetShippingLabel());
         Console.WriteLine();
         Console.WriteLine(order1.GetPackingLabel());
         Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}");
         Console.WriteLine();

         Console.WriteLine(order2.GetShippingLabel());
         Console.WriteLine();
         Console.WriteLine(order2.GetPackingLabel());
         Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");
         
       
    }
}