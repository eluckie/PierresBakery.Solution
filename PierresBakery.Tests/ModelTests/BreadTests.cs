using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_ShouldCreateAnInstanceOfBread_Bread()
    {
      Bread breadOrder = new Bread(3);
      Assert.AreEqual(typeof(Bread), breadOrder.GetType());
    }

    [TestMethod]
    public void GetBreadCount_ReturnsBreadCount_Int()
    {
      int breadCount = 3;
      Bread breadOrder = new Bread(3);
      int result = breadOrder.BreadCount;
      Assert.AreEqual(breadCount, result);
    }

  }
}
