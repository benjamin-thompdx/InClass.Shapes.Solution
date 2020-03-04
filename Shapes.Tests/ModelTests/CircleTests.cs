using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests 
{
  [TestClass]
  public class CircleTests
  {
    [TestMethod]
    public void Circle_GetCircumference_CircumferenceOfCircle()
    {
      Rectangle newRectangle = new Rectangle(6,6);
      Circle newCircle = new Circle(newRectangle);

      double result = newCircle.GetCircumference();

      Assert.AreEqual(result, 18.85); 
    }
  }

}