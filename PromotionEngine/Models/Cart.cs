using PromotionEngine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class Cart : ICart
    {
        public List<StockUnit> CartItems { get; set; }

        public List<string> AppliedPromotions { get; set; }

        public Cart()
        {
            CartItems = new List<StockUnit>();
        }

        public void AddItemsToCart(StockUnit stockUnit, int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                CartItems.Add(stockUnit);
            }
        }

        public IEnumerable<StockUnit> GetItemsFromCart(char sKUId)
        {
            return CartItems.Where(item => item.Id == sKUId);
        }

        public void ClearCart()
        {
            CartItems.Clear();
        }

        public double GetTotalCartValue()
        {
            return CartItems.Sum(item => item.Price);
        }
    }
}
