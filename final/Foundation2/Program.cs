using System;

namespace Products
{

  class Program
  {
    static void Main(string[] args)
    {

      // Create the addresses
      Address address1 = new Address("520 W 5th S", "Rexburg", "Idaho", "USA");
      Address address2 = new Address("530 W 5th S", "Rexburg", "Idaho", "USA");
      Address address3 = new Address("Nerzstraße 18", "Nuremberg", "Bavaria", "Germany");

      // Create customers
      Customer customer1 = new Customer("Marley Hadlow", address1);
      Customer customer2 = new Customer("Madison Bell", address2);
      Customer customer3 = new Customer("Johannes Gutenberg", address3);

      // Create products 
      Product product1 = new Product("Rubber Duck", "abc123", 8.99, 20);
      Product product2 = new Product("Smartphone", "phone57", 799.99, 5);
      Product product3 = new Product("Book", "book901", 17.99, 30);

      Product product4 = new Product("Headphones", "head76", 149.99, 3);
      Product product5 = new Product("Sunglasses", "sungl94", 59.99, 15);
      Product product6 = new Product("Camera", "c1234", 499.99, 2);

      Product product7 = new Product("Video Game", "game26", 39.99, 25);
      Product product8 = new Product("Laptop", "lptp22", 1199.99, 1);
      Product product9 = new Product("T-Shirt", "tshirt15", 9.99, 40);


      // Create product lists
      List<Product> products1 = new List<Product>();
      List<Product> products2 = new List<Product>();
      List<Product> products3 = new List<Product>();

      // products1
      products1.Add(product1);
      products1.Add(product2);
      products1.Add(product3);

      // products2
      products2.Add(product4);
      products2.Add(product5);
      products2.Add(product6);

      // // products3
      products3.Add(product7);
      products3.Add(product8);
      products3.Add(product9);

      // Create orders
      Order order1 = new Order(customer1, products1);
      Order order2 = new Order(customer2, products2);
      Order order3 = new Order(customer3, products3);

      order1.printPackingLabel();
      order1.printShippingLabel();
      Console.WriteLine($"The total cost is: {order1.Total.ToString("0.00")}");

      order2.printPackingLabel();
      order2.printShippingLabel();
      Console.WriteLine($"The total cost is: {order2.Total.ToString("0.00")}");

      order3.printPackingLabel();
      order3.printShippingLabel();
      Console.WriteLine($"The total cost is: ${order3.Total.ToString("0.00")}");

    }
  }
}