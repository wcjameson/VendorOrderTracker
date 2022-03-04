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
    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetAll_ReturnsOrders_OrdersList()
    {
      Order newOrder1 = new Order("baked goods");
      Order newOrder2 = new Order("cups");
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetId_OrdersInstantiateWithId_Int()
    {
      string orderName = "straws";
      Order neworder = new Order(orderName);

      int result = neworder.Id;

      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string orderName1 = "bulk flour";
      string orderName2 = "twenty bags of rice";
      Order newOrder1 = new Order(orderName1);
      Order newOrder2 = new Order(orderName2);

      Order result = Order.Find(2);
      
      Assert.AreEqual(newOrder2, result);
    }
  }
}