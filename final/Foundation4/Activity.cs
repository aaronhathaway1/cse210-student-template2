using System;

namespace ExerciseTracking
{

  abstract class Activity
  {

    // distance
    // pace
    // speed


    protected double _timeInMin;
    protected double _distance;
    protected double _pace;
    protected double _speed;

    protected string _date { get; set; }

    public Activity(int timeInMin, DateTime date, double distance)
    {
      _timeInMin = timeInMin;
      _date = date.ToString("dd MMM yyyy");
      setDistance(distance);
      setSpeed(distance, timeInMin);
      setPace(distance, timeInMin);
    }

    virtual protected void setDistance(double distance)
    {
      _distance = distance;
    }

    virtual protected void setSpeed(double distance, double timeInMin)
    {
      _speed = (distance / timeInMin);
    }

    virtual protected void setPace(double distance, double timeInMin)
    {
      _pace = distance / timeInMin;
    }


    public abstract string GetSummary();


  }

}