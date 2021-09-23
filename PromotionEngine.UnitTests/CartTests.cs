using NUnit.Framework;
using System;

namespace PromotionEngine.UnitTests
{
    public class CartTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddItemsToCart_Should_Add_Items_To_Cart()
        {
            Cart cart = new Cart();
            var stockUnit = new StockUnit { Id = 'A', Price = 50.00 };

            cart.AddItemsToCart(stockUnit);
            Assert.AreEqual(1, cart.CartItems.Count);
        }
    }
}