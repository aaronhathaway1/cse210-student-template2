using System;

namespace EventPlanning
{

  public class Address
  {

    private string _street { get; set; }
    private string _city { get; set; }
    private string _state { get; set; }
    private string _country { get; set; }

    public Address(string street, string city, string state, string country)
    {
      _street = street;
      _city = city;
      _state = state;
      _country = country;
    }

    public void printAddress()
    {
      Console.WriteLine(_street);
      Console.WriteLine($"{_city}, {_state}");
      Console.WriteLine(_country);
    }
  }

}