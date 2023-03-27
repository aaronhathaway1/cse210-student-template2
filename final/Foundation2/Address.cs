using System;

namespace Products
{
  class Address
  {
    public string Street { get; private set; }
    public string City { get; private set; }
    public string State { get; private set; }
    public string Country { get; private set; }

    public bool IsInUSA => (Country == "USA") ? true : false;
    public Address()
    {

    }

    public void printAddress()
    {
      Console.WriteLine();
    }


  }


}