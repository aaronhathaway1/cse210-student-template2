using System;

namespace Products
{
  class Product
  {
    public string Name { get; private set; }
    public string ProductId { get; private set; }
    public double IndividualPrice { get; private set; }
    public double Price { get; private set; }

    public Product()
    {

    }

    private double setPrice()
    {
      return -1;
    }

  }

}