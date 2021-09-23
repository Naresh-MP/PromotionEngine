using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Interfaces
{
    public interface IPromotion
    {
        /// <summary>
        /// Applies the promotion for the cart
        /// </summary>
        /// <param name="cart">Sotckunits added to cart</param>
        /// <returns>Retruns the total discount of the promotion</returns>
        double ApplyPromotion(ICart cart);
    }
}
