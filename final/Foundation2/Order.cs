using System;

namespace Products
{
  class Order
  {
    public List<Product> Products { get; private set; }
    public Customer Customer { get; private set; }

    public Order()
    {

    }

    public double calcTotalCost()
    {
      return -1;
    }

    public void printPackingLabel()
    {

    }

    public void printShippingLabel()
    {

    }

  }

}