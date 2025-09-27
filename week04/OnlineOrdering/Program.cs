using System;

class Program
{
  static void Main(string[] args)
  {
    // create customer, address, and set customer address
    Customer customer1 = new Customer("Rodolfo Recordon");
    Address customer1Address = new Address("742 Aspen Creek Drive", "Rexburg", "ID", "USA");
    customer1.SetAddress(customer1Address);

    // create order and products
    Order order1 = new Order(customer1);
    Product product1 = new Product("Pair of Boots", 1, 35.7, 1);
    Product product2 = new Product("Pair of Socks", 2, 1.39, 5);
    Product product3 = new Product("T-Shirt", 3, 7.99, 3);
    Product product4 = new Product("Campping Pants", 4, 15.21, 1);
    order1.AddProduct(product1, product2, product3, product4);

    // log order
    Console.WriteLine();
    Console.WriteLine("#########################################");
    Console.WriteLine();
    Console.WriteLine(order1.DisplayOrder());
    Console.WriteLine();
    Console.WriteLine("#########################################");
    Console.WriteLine();
    Console.WriteLine("Packing Label:");
    Console.WriteLine();
    Console.WriteLine(order1.GetPackingLabel());
    Console.WriteLine();
    Console.WriteLine("#########################################");
    Console.WriteLine();
    Console.WriteLine("Shipping Label:");
    Console.WriteLine();
    Console.WriteLine(order1.GetShippingLabel());
    Console.WriteLine();
  }
}