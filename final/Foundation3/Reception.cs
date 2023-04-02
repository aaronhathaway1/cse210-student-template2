using System;

namespace EventPlanning
{

  class Reception : Event
  {

    private List<string> _emailsRegistered { get; set; }

    public Reception(string title, string description, DateTime date, DateTime time, Address address, List<string> emailsRegistered) : base(title, description, date, time, address)
    {
      _emailsRegistered = emailsRegistered;
    }

    public void Register(string email)
    {
      _emailsRegistered.Add(email);
    }

    public void DisplayEmails()
    {
      _emailsRegistered.ForEach(email =>
      {
        Console.WriteLine(email);
      });
    }

  }
}