using System;

namespace EventPlanning
{


  class Event
  {
    protected string _title { get; private set; }
    protected string _description { get; private set; }
    protected DateTime _date { get; private set; }
    protected DateTime _time { get; private set; }
    protected Address _address;

    public Event(string title, string description, DateTime date, DateTime time, Address address)
    {
      _title = title;
      _description = description;
      _date = date;
      _time = time;
      _address = address;
    }

    public void DisplayStandardDetails()
    {
      Console.WriteLine($"*********** {_title} ***********");
      Console.WriteLine(_description);
      Console.WriteLine(_date.ToShortDateString());
      Console.WriteLine(_time.ToShortTimeString());
      Console.WriteLine($"Located at:");
      _address.printAddress();
      Console.WriteLine();
    }
    public void DisplayFullDetails()
    {
      DisplayStandardDetails();
      Console.WriteLine($"This event is a {GetType().Name.ToLower()}.");
      Console.WriteLine();
    }
    public void DisplayShortInfo()
    {
      Console.WriteLine($"This event is a {GetType().Name.ToLower()}.");
      Console.WriteLine(_title);
      Console.WriteLine($"It will be held on {_date.ToShortDateString()} at {_time.ToShortTimeString()} ");
      Console.WriteLine();
    }

  }
}