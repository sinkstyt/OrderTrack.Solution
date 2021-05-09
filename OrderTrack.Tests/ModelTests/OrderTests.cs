using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTrack.Models;

namespace OrderTrack.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderMethodAtStake_BehaviorExpectedOfCallToMethod_ExpectedReturn()
    {
      Order firstOrder = new Order();
      Assert.AreEqual(typeof(Order), firstOrder.GetType());
    }
  }
}