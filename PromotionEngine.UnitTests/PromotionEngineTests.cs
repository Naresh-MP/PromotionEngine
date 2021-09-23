using NUnit.Framework;
using PromotionEngine.Interfaces;
using PromotionEngine.Promotions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PromotionEngine.UnitTests
{
    public class PromotionEngineTests
    {
        ICart _cart;
        IPromotionEngine _promotionEngine;
        [SetUp]
        public void Setup()
        {
            List<IPromotion> activePromotions = new List<IPromotion> {
                new NItemsOfSameSKUFixedPrice ( 'A', 3, 130 ) ,
                new NItemsOfSameSKUFixedPrice ( 'B', 2, 45 ),
                new MultipleSKUForFixedPrice ( new List<char>{'C', 'D'}, 30)
            };
            _promotionEngine = new PromotionEngine(activePromotions);
        }

        [Test]
        public void CalculateTotalPrice_With_No_Promotions_Applied()
        {
            _cart = new Cart();
       
            _cart.AddItemsToCart(new StockUnit { Id = 'A', Price = 50 }, 1);
            _cart.AddItemsToCart(new StockUnit { Id = 'B', Price = 30 }, 1);
            _cart.AddItemsToCart(new StockUnit { Id = 'C', Price = 20 }, 1);

            var actual = _promotionEngine.CalculateTotalPrice(_cart);

            Assert.AreEqual(100, actual);
        }
    }
}
