using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
  [TestClass]
  public class RectangleTests
  {
    [TestMethod]
    public void Rectangle_GetArea_AreaOfRectangle()
    {
    // ARRANGE
    Rectangle newRectangle = new Rectangle(4,4);
    // ACT
    int result = newRectangle.GetArea();
    // ASSERT
    Assert.AreEqual(result, 16);
    }

    [TestMethod]
    public void Rectangle_IsSquare_True()
    {
      Rectangle newRectangle = new Rectangle(4, 4);
    
      bool result = newRectangle.IsSquare();
      
      Assert.AreEqual(result, true);
    }

    [TestMethod]
    public void Rectangle_IsSquare_False()
    {
      
      Rectangle newRectangle = new Rectangle(4, 5);
 
      bool result = newRectangle.IsSquare();
    
      Assert.AreEqual(result, false);
    }
    
  }
}