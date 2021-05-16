using Microsoft.AspNetCore.Mvc;

namespace OrderTrack.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult SplashPage()
    {
      return View();
    }
  }
}