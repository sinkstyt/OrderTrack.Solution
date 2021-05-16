using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OrderTrack.Models;

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
    public ActionResult CreateVendor()
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
  }
}