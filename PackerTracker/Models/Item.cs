using System.Collections.Generic;

namespace PackerTracker.Models
{
  public class Item
  {
    public string Name { get; set; }
    public int Grams { get; set; }
    public int Id { get; }
    private static List<Item> _instances = new List<Item> {};

    
    public Item(string name, int grams)
    {
      Name = name;
      Grams = grams;
      _instances.Add(this);
      Id = _instances.Count;
    }




  }
}