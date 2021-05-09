using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTrack.Models;

namespace OrderTrack.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void OrderMethodAtStake_BehaviorExpectedOfCallToMethod_ExpectedReturn()
    {
      string firstName = "Lavender";
      Vendor firstBuyer = new Vendor(firstName);
      Assert.AreEqual(typeof(Vendor), firstBuyer.GetType());
    }
  }
}