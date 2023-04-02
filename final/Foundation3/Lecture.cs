using System;

namespace EventPlanning
{

  class Lecture : Event
  {

    private string _speaker { get; set; }
    private int _capacity { get; set; }


    public Lecture(string title, string description, DateTime date, DateTime time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
      _speaker = speaker;
      _capacity = capacity;
    }



  }
}