using PromotionEngine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Promotions
{
    public class MultipleSKUForFixedPrice : IPromotion
    {
        List<char> _sKUIds;
        int _fixedPrice;

        public MultipleSKUForFixedPrice(List<char> sKUIds, int fixedPrice)
        {
            _sKUIds = sKUIds;
            _fixedPrice = fixedPrice;
        }
        
        public double ApplyPromotion(ICart cart)
        {
            double selectedItemsTotal = 0.00;
            //check cart has any sku's which has promotion
            var firstComboSKU = cart.CartItems.Where(item => item.Id == _sKUIds[0]);
            var secondComboSKU = cart.CartItems.Where(item => item.Id == _sKUIds[1]);

            //Make sure you have atlest one combo available
            if (firstComboSKU.Count() >= 1 && secondComboSKU.Count() >= 1)
            {
                int bundleCount = Math.Min(firstComboSKU.Count(), secondComboSKU.Count());
                selectedItemsTotal = (firstComboSKU.First().Price + secondComboSKU.First().Price - _fixedPrice) * bundleCount;

                return selectedItemsTotal;
            }
            return default;
        }
    }
}
