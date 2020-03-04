using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
  [TestClass]
  public class SphereTests
  {

    [TestMethod]
    public void Sphere_GetSurfaceArea_SurfaceAreaOfSphere()
    {
      Rectangle newRectangle = new Rectangle(12, 12);
      Sphere newSphere = new Sphere(newRectangle);

      double result = newSphere.GetSurfaceArea();

      Assert.AreEqual(result, 452.39);
    }

    [TestMethod]
    public void Sphere_GetVolume_VolumeOfSphere()
    {
      Rectangle newRectangle = new Rectangle(12, 12);
      Sphere newSphere = new Sphere(newRectangle);

      double result = newSphere.GetVolume();

      Assert.AreEqual(result, 904.78);
    }
  }
}