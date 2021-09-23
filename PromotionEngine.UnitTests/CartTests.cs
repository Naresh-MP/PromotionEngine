using NUnit.Framework;
using PromotionEngine.Interfaces;
using System;
using System.Linq;

namespace PromotionEngine.UnitTests
{
    public class CartTests
    {
        ICart cart;
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddItemsToCart_Should_Add_Items_To_Cart()
        {
            cart = new Cart();
            var stockUnit = new StockUnit { Id = 'A', Price = 50.00 };

            cart.AddItemsToCart(stockUnit,1);
            Assert.AreEqual(1, cart.CartItems.Count);
        }

        [Test]
        public void AddItemsToCart_Should_Add_Multiple_Items_To_Cart()
        {
            cart = new Cart();
            var stockUnitA = new StockUnit { Id = 'A', Price = 50.00 };            
            var stockUnitB = new StockUnit { Id = 'B', Price = 45.00 };

            cart.AddItemsToCart(stockUnitA, 2);
            cart.AddItemsToCart(stockUnitB, 1);
            Assert.AreEqual(3, cart.CartItems.Count);
        }

        [Test]
        
        public void GetItemsFromCart_Should_Return_VolumeOfCart_for_singleSKU()
        {
            Cart cart = new Cart();
            var stockUnit = new StockUnit { Id = 'A', Price = 50.00 };
            cart.AddItemsToCart(stockUnit, 1);

            var actual = cart.GetItemsFromCart(stockUnit.Id).Count();

            Assert.AreEqual(1, actual);
        }

        [Test]
        public void ClearCart_Should_Delete_ExistingItems()
        {
            Cart cart = new Cart();
            var stockUnit = new StockUnit { Id = 'A', Price = 50.00 };

            cart.AddItemsToCart(stockUnit, 1);
            cart.ClearCart();

            Assert.IsEmpty(cart.CartItems);
        }

        [Test]
        public void GetItemsFromCart_Should_Return_VolumeOfCart_for_MultileSKU()
        {
            Cart cart = new Cart();
            var stockUnitA = new StockUnit { Id = 'A', Price = 50.00 };
            var stockUnitB = new StockUnit { Id = 'B', Price = 45.00 };

            cart.AddItemsToCart(stockUnitA, 3);
            cart.AddItemsToCart(stockUnitB, 2);

            Assert.AreEqual(5, cart.CartItems.Count);
        }
    }
}