using Microsoft.VisualStudio.TestTools.UnitTesting;
using PackerTracker.Models;
using System.Collections.Generic;
using System;

namespace PackerTracker.Tests
{
  [TestClass]
  public class BagTests : IDisposable
  {
    public void Dispose()
    {
      Bag.ClearAll();
    }

    [TestMethod]
    public void BagConstructor_CreatesInstanceofBag_Bag()
    {
      Bag newBag = new Bag("backpack", 4400);
      Assert.AreEqual(typeof(Bag), newBag.GetType());
    }
    
    [TestMethod]
    public void AddToBag_AddsItemToBagContents_ListOfItems()
    {
      // Arrange
      Bag newBag = new Bag("backpack", 4400);
      Item newItem = new Item("water filter", 100);
      // Act
      List<Item> newContents = newBag.AddToBag(newItem);
      List<Item> testContents = new List<Item> { newItem };
      // Assert
      CollectionAssert.AreEqual(newContents, testContents);
    }


  }
}