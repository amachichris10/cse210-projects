using System;

class Program
{
    static void Main(string[] args)
    {
        Customer customer = new Customer("John Doe", new Address("123 Main St", "Anytown", "CA", "12345"));
        List<Product> products = new List<Product>
        {
            new Product("Item 1", "001", 10.99, 2),
            new Product("Item 2", "002", 15.99, 1)
        };
        Order order = new Order(customer, products);
    }
}