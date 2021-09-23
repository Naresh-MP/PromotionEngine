using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Promotions
{
    public class MultipleSKUForFixedPrice
    {
        List<char> _sKUIds;
        int _fixedPrice;

        public MultipleSKUForFixedPrice(List<char> sKUIds, int fixedPrice)
        {
            _sKUIds = sKUIds;
            _fixedPrice = fixedPrice;
        }
        public double ApplyPromotion(Cart cart)
        {
            throw new NotImplementedException();
        }
    }
}
