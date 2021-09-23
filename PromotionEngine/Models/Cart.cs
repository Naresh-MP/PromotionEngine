using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class Cart
    {
        public List<StockUnit> CartItems;

        public Cart()
        {
            CartItems = new List<StockUnit>();
        }

        public void AddItemsToCart(StockUnit stockUnit)
        {
            CartItems.Add(stockUnit);
        }
    }
}
