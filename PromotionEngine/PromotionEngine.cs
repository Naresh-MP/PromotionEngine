using PromotionEngine.Interfaces;
using System;
using System.Collections.Generic;

namespace PromotionEngine
{
    public class PromotionEngine : IPromotionEngine
    {
        List<IPromotion> _activePromotions;

        public PromotionEngine(List<IPromotion> activePromotions)
        {
            _activePromotions = activePromotions;
        }

        public double CalculateTotalPrice(ICart cart)
        {
            double totalDiscount = 0.00;
            cart.AppliedPromotions = new List<string>();

            foreach (var promotion in _activePromotions)
            {
                totalDiscount += promotion.ApplyPromotion(cart);
            }

            double totalCartValueAfterDiscount = cart.GetTotalCartValue() - totalDiscount;

            return totalCartValueAfterDiscount;
        }
    }
}
