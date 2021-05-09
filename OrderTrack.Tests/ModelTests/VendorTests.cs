using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTrack.Models;
using System;
using System.Collections.Generic;

namespace OrderTrack.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
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

    [TestMethod]
    public void SetVendorDescription_AssignsVendorDescription_Description()
    {
      string firstName = "Chaz";
      string description = "coffee spot at 77 Main st";
      Vendor thirdBuyer = new Vendor(firstName);
      thirdBuyer.Description = description;
      string resultDescription = thirdBuyer.Description;
      Assert.AreEqual(description, resultDescription);
    }

    [TestMethod]
    public void VendorConstructor_InstanceHasEmptyListOfOrders_EmptyListOfOrders()
    {
      string firstName = "Cyd";
      Vendor fourthBuyer = new Vendor(firstName);
      List<Order> expectedList = new List<Order> {};
      List<Order> resultList = fourthBuyer.Orders;
      CollectionAssert.AreEqual(expectedList, resultList);
    }
  }
}