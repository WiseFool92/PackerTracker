using System.Collections.Generic;

namespace PackerTracker.Models
{
  public class Bag
  {
    public string BagName { get; set; }
    public int WeightLimit { get; set; }
    public List<Item> Contents { get; set; }
    public int Id { get; }
    private static List<Bag> _allBags = new List<Bag> {};

    public Bag(string bagName, int weightLimit)
    {
      BagName = bagName;
      WeightLimit = weightLimit;
      Contents = new List<Item> {};
      _allBags.Add(this);
      Id = _allBags.Count;
    }

    public static void ClearAll()
    {
      _allBags.Clear();
    }

    public static List<Bag> GetAll()
    {
      return _allBags;
    }
  
    public static Bag Find(int searchId)
    {
      return _allBags[searchId-1];
    }

    public List<Item> AddToBag(Item myItem)
    {
      Contents.Add(myItem);
      return Contents;
    }

    public int BagWeight()
    {
      return 0;
    }

  }
}

