using System;

namespace Products
{
  class Address
  {
    private string Street { get; set; }
    private string City { get; set; }
    private string State { get; set; }
    public string Country { get; private set; }

    public Address(string street, string city, string state, string country)
    {
      Street = street;
      City = city;
      State = state;
      Country = country;
    }

    public Boolean IsInUSA()
    {
      if (Country == "USA")
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public void printAddress()
    {
      Console.WriteLine(Street);
      Console.WriteLine($"{City}, {State}");
      Console.WriteLine(Country);
    }


  }


}