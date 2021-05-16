using Microsoft.AspNetCore.Mvc;
using OrderTrack.Models;
using System.Collections.Generic;
using System;

namespace OrderTrack.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("vendors/{vendorId}/orders")]
    public ActionResult Index(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      List<Order> _allOrders = Order.GetAllOrders();
      Dictionary<string, object> model = new Dictionary<string, object> { };
      model.Add("vendor", vendor);
      model.Add("orders", _allOrders);
      return View(model);
    }

    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor model = Vendor.Find(vendorId);
      return View(model);
    }

    [HttpPost("vendors/{vendorId}/orders")]
    public ActionResult CreateOrder(string title, string description, string baguettes, string croissants, Vendor vendor)
    {
      DateTime date = DateTime.Now;
      Order newOrder = new Order(title, description, date);
      newOrder.CalcPrice(baguettes, croissants);
      Vendor model = Vendor.Find(vendor.VendorId);
      int id = model.VendorId;
      return RedirectToAction("Index", id);
    }
  }
}