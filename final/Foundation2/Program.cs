using System;
using System.Diagnostics;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        //Order 1 
        Address address1 = new Address("101 E Viking St", "Rexburg,", "ID", "83460");
        Customer customer1 = new Customer("Bob Ross", address1);
        List<Product> productsList1 = new List<Product>();
        
        Product p1 = new Product("Paint Brush", "PB1", 1.47, 2);
        Product p2 = new Product("Assorted Paints", "AP1", 40.99, 1);
        Product p3 = new Product("Super Value Blank Canvas Set", "SVBCS1", 12.99, 30);
        Product p4 = new Product("A-Frame Studio Floor Easel", "ASFE", 19.99, 30);

        productsList1.Add(p1);
        productsList1.Add(p2);
        productsList1.Add(p3);
        productsList1.Add(p4);

        Order order1 = new Order(productsList1, customer1);
        Console.WriteLine("Order Number: 1");
        order1.DisplayResults();
        Console.WriteLine();
        Console.ReadLine();
        Console.Clear();

        //Order 2
        Address address2 = new Address("101 E Viking St", "Rexburg,", "ID", "83460");
        Customer customer2 = new Customer("", address2);
        List<Product> productsList2 = new List<Product>();

        Product p5 = new Product("Pre-made social media account", "PSMA", 99.99, 1);
        Product p6 = new Product("Projector", "P1", 76.99, 1);
        Product p7 = new Product("Projector screen", "PS1", 20.62, 1);

        productsList2.Add(p5);
        productsList2.Add(p6);
        productsList2.Add(p7);

        Order order2 = new Order(productsList2, customer2);
        Console.WriteLine("Order Number: 2");
        order2.DisplayResults();
        Console.WriteLine();
        Console.ReadLine();
        Console.Clear();

        //Order 3
        Address address3 = new Address("7135 N Linder Rd", "Meridian,", "ID", "83646");
        Customer customer3 = new Customer("Bishop", address3);
        List<Product> productsList3 = new List<Product>();

        Product p8 = new Product("4 Steak pack", "4SP", 240, 30);
        Product p9 = new Product("Smithfield Frozen Pork Riblet", "SFPR1", 53.95, 20);
        Product p10 = new Product("Kraft Frozen Oscar Mayer Beef Frank - Hot Dog, 10 Pound", "KFOMBFHD10P", 111.54, 2);

        productsList3.Add(p8);
        productsList3.Add(p9);
        productsList3.Add(p10);

        Order order3 = new Order(productsList3, customer3);
        Console.WriteLine("Order Number: 3");
        order3.DisplayResults();
        Console.WriteLine();
        Console.ReadLine();
        Console.Clear();
    }
}