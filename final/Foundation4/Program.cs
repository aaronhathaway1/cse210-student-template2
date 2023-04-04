using System;

namespace ExerciseTracking
{
  class Program

  {


    static void Main(string[] args)
    {

      DateTime date1 = DateTime.Today;
      DateTime date2 = DateTime.Today;
      DateTime date3 = DateTime.Today;


      // Create instance of each activity
      Running running = new Running(60, date1, 1);
      Cycling cycling = new Cycling(60, date2, 30);
      Swimming swimming = new Swimming(30, date3, 20);

      // Add Activity to list 
      List<Activity> acitivties = new List<Activity>{
        running, cycling, swimming
      };

      // Iterate through and call the GetSummary
      acitivties.ForEach(activity =>
      {
        Console.WriteLine(activity.GetSummary());
        Console.WriteLine();
      });



    }
  }
}