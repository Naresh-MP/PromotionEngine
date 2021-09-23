using PromotionEngine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Promotions
{
    public class NItemsOfSameSKUFixedPrice : IPromotion
    {
        private readonly char _sKU;
        private readonly double _fixedPrice;
        private readonly int _quantity;

        public NItemsOfSameSKUFixedPrice(char sKUId, int quantity, double fixedPrice)
        {
            _sKU = sKUId;
            _quantity = quantity;
            _fixedPrice = fixedPrice;
        }

        public double ApplyPromotion(ICart cart)
        {
            double discount = 0.00;
            var selectedItems = cart.CartItems.Where(x => x.Id == _sKU);
            double unitPrice = selectedItems.First().Price;
            double totalSKUCartValue = selectedItems.Sum(item => item.Price);

            int itemsInCart = selectedItems.Count();

            if (itemsInCart >= _quantity && IsPromotionApplied(cart))
            {
                discount = (itemsInCart / _quantity * _fixedPrice) + (itemsInCart % _quantity * unitPrice);
                cart.AppliedPromotions.Add(_sKU.ToString());
                return totalSKUCartValue - discount;
            }
            return discount;
        }

        bool IsPromotionApplied(ICart cart)
        {
            if (!cart.AppliedPromotions.Contains(_sKU.ToString()))
            {
                return true;
            }
            return false;
        }
    }
}
