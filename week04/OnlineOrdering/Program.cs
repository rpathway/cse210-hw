using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1   = new Address("1000 5th Ave", "New York", "NY", "USA");
        Customer customer1 = new Customer("Joe Smith", address1);
        Order order1 = new Order(customer1);

        Product product1 = new Product("Alienware m15 15.6 inch FHD Gaming Laptop (Lunar Light)", "B08BZX1VTS", 19062.38f, 1);
        Product product2 = new Product("Logitech Wireless Gaming Mouse G700", "B003VAM32E", 959.39f, 1);
        Product product3 = new Product("Standard Full-Size Keyboard, White", "B0DD3JYHZH", 13000.00f, 1);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}\n");

        Address address2   = new Address("1 Austin Terrace", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Roe", address2);
        Order order2 = new Order(customer2);

        Product product4 = new Product("Samsung QB85C QBC Series", "B0CHJZJFP3", 11357.83f, 2);
        Product product5 = new Product("Extra Long USB Micro Cable", "B0BWMLPF56", 1136.59f, 3);

        order2.AddProduct(product4);
        order2.AddProduct(product5);

        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}");
    }
}