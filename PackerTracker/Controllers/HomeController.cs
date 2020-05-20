using Microsoft.AspNetCore.Mvc;
using PackerTracker.Models;
using System.Collections.Generic;

namespace PackerTracker.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/Home")]
    public ActionResult Index()
    {
      return View();
    }
  }
}