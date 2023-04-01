using System;

namespace Products
{
  class Customer
  {
    public string Name { get; private set; }
    public Address Address { get; private set; }

    public Customer(string name, Address address)
    {
      Name = name;
      Address = address;
    }

    public Boolean IsInUSA()
    {
      if (Address.Country == "USA")
      {
        return true;
      }
      else
      {
        return false;
      }
    }


  }

}