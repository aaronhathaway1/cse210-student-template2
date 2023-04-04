using System;

namespace ExerciseTracking
{

  class Swimming : Activity
  {

    private double _numLaps;
    public Swimming(int timeInMin, DateTime date, double distance) : base(timeInMin, date, distance)
    {
      _numLaps = distance * 50 / 1000 * 0.62;
    }



    public override string GetSummary()
    {

      return $"{base._date}, {GetType().Name} ({base._timeInMin} min) - Distance {base._distance.ToString("0.00")} laps, Speed {base._speed.ToString("0.00")} mph, Pace: {_numLaps.ToString("0.00")} min per lap";
      // 03 Nov 2022 Swimming (30 min)- Distance 300 miles, Speed 6.0 mph, Pace: 10.0 min per meter
    }
  }

}