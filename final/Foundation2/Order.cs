using System;

namespace Products
{
  class Order
  {
    public List<Product> Products { get; private set; }
    public Customer Customer { get; private set; }
    public double Total { get; private set; }

    public Order(Customer customer, List<Product> products)
    {
      Products = products;
      Customer = customer;
      calcTotalCost();
    }

    public void calcTotalCost()
    {
      double total = 0;

      Products.ForEach(product =>
      {
        total += product.Price;
      });

      double shipCost = Customer.Address.IsInUSA() ? 5 : 35;
      total += shipCost;

      Total = total;
    }

    public void printPackingLabel()
    {
      //List the name and poduct Id
      Products.ForEach((product) =>
      {
        Console.WriteLine("*******************");
        Console.WriteLine($"Product Name: {product.Name}");
        Console.WriteLine($"Product Id: {product.ProductId}");
        Console.WriteLine();
      });

    }

    public void printShippingLabel()
    {
      //List the customer namd and address
      Console.WriteLine($"Ship to: {Customer.Name}");
      Customer.Address.printAddress();
      Console.WriteLine();
    }

  }

}