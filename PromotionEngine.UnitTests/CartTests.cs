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

            var ex = Assert.Throws<NotImplementedException>(() => cart.AddItemsToCart(stockUnit));
            Assert.That(ex.Message, Is.EqualTo("The method or operation is not implemented"));
        }
    }
}