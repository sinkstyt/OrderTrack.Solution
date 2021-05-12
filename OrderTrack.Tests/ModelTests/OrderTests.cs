using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTrack.Models;
using System;

namespace OrderTrack.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderMethodAtStake_BehaviorExpectedOfCallToMethod_ExpectedReturn()
    {
      string title = "big order";
      string description = "three baguettes on Monday";
      DateTime date = DateTime.Now;
      Order firstOrder = new Order(title, description, date);
      Assert.AreEqual(typeof(Order), firstOrder.GetType());
    }
  }
}