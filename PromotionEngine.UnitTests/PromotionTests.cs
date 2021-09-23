using NUnit.Framework;
using PromotionEngine.Interfaces;
using PromotionEngine.Promotions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PromotionEngine.UnitTests
{
    public class PromotionTests
    {

        [SetUp]
        public void Setup()
        {
        }

        public void ApplyPromotion_NItemsOfSameSKUFixedPrice_Should_Throw_NotImplementedException()
        {
            Cart cart = new Cart();
            NItemsOfSameSKUFixedPrice _NItemsOfSameSKUFPromotion = new NItemsOfSameSKUFixedPrice('A', 3, 130);
            cart.AddItemsToCart(new StockUnit { Id = 'A', Price = 50.00 }, 3);

            var ex = Assert.Throws<NotImplementedException>(() => _NItemsOfSameSKUFPromotion.ApplyPromotion(cart)); ;
            Assert.That(ex.Message, Is.EqualTo("The method or operation is not implemented"));
        }

        [Test]
        public void ApplyPromotion_MultipleSKUForFixedPrice_Should_Throw_NotImplementedException()
        {
            Cart cart = new Cart();
            MultipleSKUForFixedPrice _MultipleSKUPromotion = new MultipleSKUForFixedPrice(new List<char> { 'C', 'D' }, 45);
            cart.AddItemsToCart(new StockUnit { Id = 'C', Price = 20.00 }, 1);
            cart.AddItemsToCart(new StockUnit { Id = 'D', Price = 15.00 }, 1);

            var ex = Assert.Throws<NotImplementedException>(() => _MultipleSKUPromotion.ApplyPromotion(cart)); ;

            Assert.That(ex.Message, Is.EqualTo("The method or operation is not implemented"));
        }

    }
}