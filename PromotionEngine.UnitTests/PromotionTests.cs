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
        IPromotion _NItemsOfSameSKUFPromotion;
        IPromotion _MultipleSKUPromotion;
        [SetUp]
        public void Setup()
        {
            _NItemsOfSameSKUFPromotion = new NItemsOfSameSKUFixedPrice('A', 3, 130);
            _MultipleSKUPromotion = new MultipleSKUForFixedPrice(new List<char> { 'C', 'D' }, 30);
        }

        [Test]
        public void ApplyPromotion_NItemsOfSameSKUFixedPrice_Should_Apply_Promotion()
        {
            Cart cart = new Cart();            
            cart.AddItemsToCart(new StockUnit { Id = 'A', Price = 50.00 }, 3);

            var actual = _NItemsOfSameSKUFPromotion.ApplyPromotion(cart);

            Assert.AreEqual(130, actual);
        }


        [Test]
        public void ApplyPromotion_MultipleSKUForFixedPrice_Should_Throw_NotImplementedException()
        {
            Cart cart = new Cart();
            
            cart.AddItemsToCart(new StockUnit { Id = 'C', Price = 20.00 }, 1);
            cart.AddItemsToCart(new StockUnit { Id = 'D', Price = 15.00 }, 1);

            var actual = _MultipleSKUPromotion.ApplyPromotion(cart);

            Assert.AreEqual(5, actual);
        }

    }
}