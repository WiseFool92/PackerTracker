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

    [HttpGet("/bags/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpGet("/bags/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object> ();
      Bag selectedBag = Bag.Find(id);
      List<Item> bagContents = selectedBag.Contents;
      model.Add("bag", selectedBag);
      model.Add("contents", bagContents);
      return View(model);
    }

    [HttpGet("/bags/{id}/additem")]
    public ActionResult NewItem()
    {
      return View();
    }

    // [HttpPost("/bags/{id}/additems")]
    // public ActionResult Create(int id, string itemName, int grams)
    // {
    // Bag selectedBag = Bag.Find(id);
    // Item newItem = new Item(itemName, grams);
    // selectedBag.AddToBag(newItem);
    // }  THIS MIGHT WORK -- Definitely MIGHT WORK!
    

    
  }
}