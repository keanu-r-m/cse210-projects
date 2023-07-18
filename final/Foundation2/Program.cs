using System;

class Program
{
    static void Main(string[] args)
    {
        Customer customerOne = new Customer("Keanu Mine", new Address("123 Main Street", "New York", "NY", "United States"));

        Customer customerTwo = new Customer("Eliza Cyrena", new Address("456 Park Avenue", "Buenos Aires", "CABA", "Argentina"));

        Product productOne = new Product("Wireless Buetooth Earbuds", 837461, 79.99f, 3);
        Product productTwo = new Product("Portable Power Bank", 524789, 29.99f, 1);
        Product productThree = new Product("Digital Camera", 982156, 249.99f, 2);
        Product productFour = new Product("Smartwatch with Fitness Tracker", 731290, 149.99f, 4);

        Order orderOne = new Order(customerOne, new List<Product>{productOne, productTwo});
        Console.WriteLine("Product One:");
        orderOne.MakePackingLabel();
        Console.WriteLine($"\n{orderOne.MakeShippingLabel()}");
        Console.WriteLine($"Total cost: ${orderOne.ComputeTotalCostOrder()}");

        Order orderTwo = new Order(customerTwo, new List<Product>{productThree, productFour});
        Console.WriteLine("\n\nProduct Two:");
        orderTwo.MakePackingLabel();
        Console.WriteLine($"\n{orderTwo.MakeShippingLabel()}");
        Console.WriteLine($"Total cost: ${orderTwo.ComputeTotalCostOrder()}");
    }
}