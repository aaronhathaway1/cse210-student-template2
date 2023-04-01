using System;

namespace Products
{
  class Product
  {
    public string Name { get; private set; }
    public string ProductId { get; private set; }
    public double Price { get; private set; }
    public double UnitPrice { get; private set; }
    public int Quantity { get; private set; }

    public Product(string name, string productId, double unitPrice, int quantity)
    {
      Name = name;
      ProductId = productId;
      UnitPrice = unitPrice;
      Quantity = quantity;

      setPrice();
    }

    private void setPrice()
    {
      Price = UnitPrice * Quantity;
    }

  }

}