using Microsoft.AspNetCore.Mvc;
using PackerTracker.Models;
using System.Collections.Generic;

namespace PackerTracker.Controllers
{
  public class ItemsController : Controller
  {
    [HttpGet("/items")]
    public ActionResult Index()
    {
      List<Item> allItems = Item.GetAll();
      return View(allItems);
    }

    [HttpGet("/items/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/items")]
    public ActionResult Create(string itemName, int grams)
    {
      Item newItem = new Item(itemName, grams);
      return RedirectToAction("Index");
    }

    // [HttpGet("/items/{id}")]
    // public ActionResult Show(int id)
    // {
    //   Dictionary<string, object> model = new Dictionary<string, object> ();
    //   Item selectedItem = Item.Find(id)

    //   model.Add("bag")
    // }
    // [HttpGet("/bags/{id}")]
    // public ActionResult Show(int id)
    // {
    //   Bag selectedBag = Bag.Find(id);
    //   List<Item> bagContents = selectedBag.Contents;
    //   model.Add("bag", selectedBag);
    //   model.Add("contents", bagContents);
    //   return View(model);
    // }
  }
}