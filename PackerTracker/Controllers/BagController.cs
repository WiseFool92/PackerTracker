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

    [HttpPost("/bags")]
    public ActionResult Create(string bagName, int maxWeight)
    {
      Bag newBag = new Bag(bagName, maxWeight);
      return RedirectToAction("Index");
    }

    [HttpGet("bags/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/")]
    public ActionResult 
    {
      return Redirect
    }

    // [HttpPost("/jobs")]
    // public ActionResult Create(string title, string description, string pay, string phone)
    // {
    //   Jobs newContract = new Jobs(title, description, pay, phone);
    //   return RedirectToAction("Index");
    // }
  }
}