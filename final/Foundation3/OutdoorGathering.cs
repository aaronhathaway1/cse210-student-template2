using System;

namespace EventPlanning
{

  class OutdoorGathering : Event
  {

    private string _weather { get; set; }
    public OutdoorGathering(string title, string description, DateTime date, DateTime time, Address address, string weather) : base(title, description, date, time, address)
    {
      _weather = weather;
    }

    public void DisplayWeather()
    {
      Console.WriteLine($"It look like it will be {_weather}.");
    }

  }
}