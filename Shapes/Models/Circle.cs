using System;

namespace Shapes.Models
{
  public class Circle
  {
    public Rectangle Face { get; set; }

    public Circle (Rectangle sideCircle)
    {
        Face = sideCircle;
    }
    public double GetCircumference()
    {
      int diameter = Face.Length;
      int radius = diameter / 2;
      double pi = Math.PI;
      double circumference = 2 * pi * radius;
      return Math.Round(circumference, 2); 
    }
  }
}