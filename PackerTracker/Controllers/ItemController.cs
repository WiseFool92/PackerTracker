using Microsoft.AspNetCore.Mvc;
using PackerTracker.Models;
using System.Collections.Generic;

namespace PackerTracker.Controllers
{
  public class ItemsController : Controller
  {
    [HttpGet("/item")]
    public ActionResult Index()
    {
      List<Item> allItems = Item.GetAll();
      return View(allItems);
    }

    [HttpGet("/CreateForm")]
    public ActionResult CreateForm()
    {
      return View();
    }

    // [HttpPost("/item")]
    // public ActionResult Create(string title, string description, string pay, string phone)
    // {
    //   Jobs newContract = new Jobs(title, description, pay, phone);
    //   return RedirectToAction("Index");
    // }
  }
}