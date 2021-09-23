using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Promotions
{
    public class NItemsOfSameSKUFixedPrice 
    {
        private readonly char _sKU;
        private readonly double _fixedPrice;
        private readonly int _quantity;
        public List<char> AppliedPromotions { get; set; }
        public NItemsOfSameSKUFixedPrice(char sKUId, int quantity, double fixedPrice)
        {
            _sKU = sKUId;
            _quantity = quantity;
            _fixedPrice = fixedPrice;
        }

        public double ApplyPromotion(Cart cart)
        {
            throw new NotImplementedException();
        }
    }
}
