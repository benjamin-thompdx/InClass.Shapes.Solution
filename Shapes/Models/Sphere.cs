using System;

namespace Shapes.Models
{
  public class Sphere
  {
    public Rectangle Face { get; set; }

    public Sphere (Rectangle sideSphere)
    {
      Face = sideSphere;
    }
    public double GetSurfaceArea()
    {
      int diameter = Face.Length;
      int radius = diameter / 2;
      double pi = Math.PI;
      double surfaceArea = (4 * pi * (radius * radius));
      return Math.Round(surfaceArea, 2);
    }
    public double GetVolume()
    {
      int diameter = Face.Length;
      int radius = diameter / 2;
      double pi = Math.PI;
      Console.WriteLine(pi);
      double power = Math.Pow(radius, 3);
      double volume = ((4 * pi * power)/3);
      return Math.Round(volume, 2);
    }
  }
}