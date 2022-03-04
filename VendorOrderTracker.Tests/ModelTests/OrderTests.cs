using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrderTracker.Models;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetDescription_ReturnDescription_String()
    {
      string description = "test";
      Order newOrder1 = new Order(description);
      string result = newOrder1.Description;
      Assert.AreEqual(description, result);
    }
    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      string description = "test";
      Order newOrder2 = new Order(description);
      string updatedDescription = "a test string";
      newOrder2.Description = updatedDescription;
      string result = newOrder2.Description;
      Assert.AreEqual(updatedDescription, result);
    }
  }
}