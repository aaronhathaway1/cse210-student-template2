using System;

namespace EventPlanning
{


  class Program
  {
    static void Main(string[] args)
    {

      //Creating Dates
      DateTime date1 = DateTime.Today.AddDays(3);
      DateTime date2 = DateTime.Today.AddDays(4);
      DateTime date3 = DateTime.Today.AddDays(5);

      // Create the addresses
      Address address1 = new Address("520 W 5th S", "Rexburg", "Idaho", "USA");
      Address address2 = new Address("530 W 5th S", "Rexburg", "Idaho", "USA");
      Address address3 = new Address("Nerzstraße 18", "Nuremberg", "Bavaria", "Germany");

      // Creating times 
      DateTime time1 = new DateTime(1, 1, 1, 14, 30, 0);
      DateTime time2 = new DateTime(1, 1, 1, 18, 00, 0);
      DateTime time3 = new DateTime(1, 1, 1, 8, 45, 0);


      // Creating Email
      List<string> registeredEmails = new List<string> { "aaronhathaway1@hotmail.com", "someone@gmail.com" };

      //Creating Events
      Lecture lecture = new Lecture("Devotional", "Come unto Christ with us at devotional.", date1, time1, address1, "Elder Holland", 3000);

      Reception reception = new Reception("The Marriage of Aaron Hathaway and Madison Burt", "Please join us to celebrate the marraige of Aaron Hathaway and Madison Burt.", date1, time2, address2, registeredEmails);

      OutdoorGathering outdoorGathering = new OutdoorGathering("Outdoor Reception for Aaron & Madi", "Some other silly reception, but outside this time.", date3, time3, address3, "cloudy with a chance of meatballs");



      lecture.DisplayStandardDetails();
      lecture.DisplayFullDetails();
      lecture.DisplayShortInfo();

      reception.DisplayStandardDetails();
      reception.DisplayFullDetails();
      reception.DisplayShortInfo();
      reception.DisplayEmails();
      reception.Register("madib@gmail.com");
      reception.DisplayEmails();


      outdoorGathering.DisplayStandardDetails();
      outdoorGathering.DisplayFullDetails();
      outdoorGathering.DisplayShortInfo();
      outdoorGathering.DisplayWeather();




    }
  }
}