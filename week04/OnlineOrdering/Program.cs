using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Rexburg", "Idaho", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);
        
        order1.AddProduct(new Product("Laptop", "TECH-001", 850.00, 1));
        order1.AddProduct(new Product("Wireless Mouse", "TECH-002", 25.50, 2));

        Address address2 = new Address("Av. Corrientes 1500", "Buenos Aires", "CABA", "Argentina");
        Customer customer2 = new Customer("Maria Perez", address2);
        Order order2 = new Order(customer2);
        
        order2.AddProduct(new Product("Smartphone", "TECH-003", 500.00, 1));
        order2.AddProduct(new Product("Phone Case", "TECH-004", 15.00, 3));
        order2.AddProduct(new Product("Screen Protector", "TECH-005", 10.00, 2));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}");
        
        Console.WriteLine("\n-----------------------------------\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
    }
}