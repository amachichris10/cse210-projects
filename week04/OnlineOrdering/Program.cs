using System;

class Program
{
    static void Main(string[] args)
    {

        Order order1 = new Order(new Customer("John Doe", new Address("123 Main St", "Anytown", "CA", "USA")), new List<Product>
        {
            new Product("Item 1", "001", 10.99, 2),
            new Product("Item 2", "002", 15.99, 1)
        });
        
        Order order2 = new Order(new Customer("Jane Smith", new Address("456 Elm St", "Othertown", "ON", "Canada")), new List<Product>
        {
            new Product("Item 3", "003", 20.99, 3),
            new Product("Item 4", "004", 5.99, 5)
        });

        Console.Clear();
        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():0.00}");
        Console.WriteLine("\nOrder 2:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():0.00}");
    }
}