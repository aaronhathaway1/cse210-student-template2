using System;

namespace Products
{
  class Customer
  {
    public string Name { get; private set; }
    public Address Address { get; private set; }
    public bool IsInUSA => (Address.Country == "USA") ? true : false;


    public Customer(string name, Address address)
    {
      Name = name;
      Address = address;
    }


  }

}