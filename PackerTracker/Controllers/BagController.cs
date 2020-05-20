using Microsoft.AspNetCore.Mvc;
using PackerTracker.Models;
using System.Collections.Generic;

namespace PackerTracker.Controllers
{
  public class BagsController : Controller
  {
    [HttpGet("/bags")]
    public ActionResult Index()
    {
      List<Bag> allBags = Bag.GetAll();
      return View(allBags);
    }

    [HttpGet("/CreateForm")]
    public ActionResult CreateForm()
    {
      return View();
    }

    // [HttpPost("/jobs")]
    // public ActionResult Create(string title, string description, string pay, string phone)
    // {
    //   Jobs newContract = new Jobs(title, description, pay, phone);
    //   return RedirectToAction("Index");
    // }
  }
}