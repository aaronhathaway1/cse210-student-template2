using System;

namespace ExerciseTracking
{

  class Running : Activity
  {
    new private double _distance { get; set; }

    public Running(int timeInMin, DateTime date, double distance) : base(timeInMin, date, distance)
    {

    }

    public double getDistance()
    {
      return _distance;
    }



    public override string GetSummary()
    {
      return $"{base._date}, {GetType().Name} ({base._timeInMin} min) - Distance {base._distance.ToString("0.00")} miles, Speed {(base._speed * 60).ToString("0.00")} mph, Pace: {base._pace.ToString("0.00")} min per mile";
      // 03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
    }
  }

}