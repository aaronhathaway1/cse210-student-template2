using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shapes
{
  public abstract class Shape
  {
    protected string _color;

    public Shape(string color)
    {
      setColor(color);
    }


    protected void setColor(string color)
    {
      _color = color;
    }


    public string getColor()
    {
      return _color;
    }

    public abstract double getArea();


  }
}