using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Interfaces
{
    public interface IPromotionEngine
    {
        /// <summary>
        /// Caliculates the final value after applying active promotions
        /// </summary>
        /// <param name="cart">List of items added cart</param>
        /// <returns>Retruns the total value of car after applying promotions</returns>
        double CalculateTotalPrice(ICart cart);
    }
}
