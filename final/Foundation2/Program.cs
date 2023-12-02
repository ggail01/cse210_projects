using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation2 World!");

        // Create products
        Product product1 = new Product("Laptop", "LP001", 800.00, 1);
        Product product2 = new Product("Smartphone", "SP002", 500.00, 1);
        Product product3 = new Product("Headphones", "HP003", 180.00, 2);
        Product product4 = new Product("Book", "B004", 50.00, 3);
        Product product5 = new Product("Coffee Mug", "CFM005", 20.00, 2);
        Product product6 = new Product("Desk Chair", "DC006", 120.00, 4);

        // Create customer address
        Address address1 = new Address("180 Main St", "Cityville", "CA", "USA");
        Address address2 = new Address("Blk 2 Lot 15 G.Araneta St", "Quezon City", "MNL", "Philippines");

        // Create customers
        Customer customer1 = new Customer("Kyla Talag", address1);
        Customer customer2 = new Customer("Abigail Bado", address2);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product3);
        order1.AddProduct(product5);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product4);
        order2.AddProduct(product6);


        // Display packing labels, shipping labels, and total prices
        Console.WriteLine("\n--- Order 1 ---");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Price -- $" + order1.CalculateTotalCosts());
        Console.WriteLine("-------------------------");

        Console.WriteLine("\n--- Order 2 ---");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Price -- $" + order2.CalculateTotalCosts());
        Console.WriteLine("-------------------------");
        Console.WriteLine();
    }
}