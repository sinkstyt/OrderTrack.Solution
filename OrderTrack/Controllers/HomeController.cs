using Microsoft.AspNetCore.Mvc;
using OrderTrack.Models;

namespace OrderTrack.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/enter-vendor")]
    public ActionResult EnterVendor()
    {
      return View();
    }
  }
}