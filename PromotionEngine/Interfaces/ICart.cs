using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Interfaces
{
    public interface ICart
    {
        public List<StockUnit> CartItems { get; set; }
        void AddItemsToCart(StockUnit stockUnit, int quantity);
        IEnumerable<StockUnit> GetItemsFromCart(char sKUId);
        void ClearCart();
        double GetTotalCartValue();
    }
}
