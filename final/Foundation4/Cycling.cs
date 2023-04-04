using System;

namespace ExerciseTracking
{
  class Cycling : Activity
  {

    new private double _speed { get; set; }
    public Cycling(int timeInMin, DateTime date, double distance) : base(timeInMin, date, distance)
    {

    }


    public override string GetSummary()
    {
      return $"{base._date}, {GetType().Name} ({base._timeInMin} min) - Distance {base._distance.ToString("0.00")} miles, Speed {base._speed.ToString("0.00")} mph, Pace: {_pace.ToString("0.00")} min per mile";
      // 03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
    }
  }

}