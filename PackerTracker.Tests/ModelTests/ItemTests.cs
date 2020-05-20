using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PackerTracker.Models;

namespace PackerTracker.Tests
{
  [TestClass] public class ItemTests : IDisposable
  {
    public void Dispose()
    {
      Item.ClearAll();
    }

    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Item newItem = new Item("test", 214);
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }

    [TestMethod]
    public void GetNameAndWeight_ReturnsNameAndWeight_StringAndInt()
    {
      //Arrange
      string name = "water filter";
      int grams = 100;
      Item newItem = new Item(name, grams);
      //Act
      string result1 = newItem.Name;
      int result2 = newItem.Grams;
      //Assert
      Assert.AreEqual(name, result1);
      Assert.AreEqual(grams, result2);
    }



  }  
}