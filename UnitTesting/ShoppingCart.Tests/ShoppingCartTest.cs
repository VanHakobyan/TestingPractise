using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoppingCart.Tests
{
    [TestClass]
    public class ShoppingCartTest
    {
        private ShoppingCart _shoppingCart;
        private Item _item;

        [TestInitialize]
        public void TestInitialize()
        {
            Debug.Write("Test Initialize");
            _item = new Item() { Name = "Unit test", Quantity = 10 };
            _shoppingCart = new ShoppingCart();
            _shoppingCart.Add(item: _item);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Debug.Write("Test Cleanup");
            _shoppingCart.Dispose();
        }

        [TestMethod]
        public void ShoppingCart_CheckOut_ContainsItem()
        {
            CollectionAssert.Contains(_shoppingCart.Items,_item);
        }

        [TestMethod]
        public void ShoppingCart_RemoveItem_Empty()
        {
            const int expected = 0;
            _shoppingCart.Remove(0);
            Assert.AreEqual(expected,_shoppingCart.Count);
        }

    }
}
