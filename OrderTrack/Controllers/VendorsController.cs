using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OrderTrack.Models;
using System;

namespace OrderTrack.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
    List<Vendor> vendorsList = Vendor.GetAllVendors();
    return View(vendorsList);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorDescription)
    {
      Vendor newVendor = new Vendor(vendorName);
      newVendor.Description = vendorDescription;
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{vendorId}")]
    public ActionResult Show(int vendorId)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor thisVendor = Vendor.Find(vendorId);
      List<Order> ordersByVendor = thisVendor.GetOrdersThisVendor();
      model.Add("vendor", thisVendor);
      model.Add("orders", ordersByVendor);
      return View(model);
    }

    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string title, string description, string baguettes, string croissants)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor thisVendor = Vendor.Find(vendorId);
      DateTime date = DateTime.Now;
      Order newOrder = new Order(title, description, date);
      thisVendor.AddOrder(newOrder);
      List<Order> ordersByVendor = thisVendor.GetOrdersThisVendor();
      model.Add("orders", ordersByVendor);
      model.Add("category", thisVendor);
      return View("Index", model);
    }
  }
}