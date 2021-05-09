using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTrack.Models;

namespace OrderTrack.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_ReturnsAnInstanceWhoseTypeIsVendor_Vendor()
    {
      string firstName = "Lavender";
      Vendor firstBuyer = new Vendor(firstName);
      Assert.AreEqual(typeof(Vendor), firstBuyer.GetType());
    }

    [TestMethod]
    public void VendorConstructor_ReturnsVendorName_Name()
    {
      string firstName = "Lilac";
      Vendor secondBuyer = new Vendor(firstName);
      string resultName = secondBuyer.Name;
      Assert.AreEqual(firstName, resultName);
    }
  }
}