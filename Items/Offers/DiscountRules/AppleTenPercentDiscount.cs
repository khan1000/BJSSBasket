using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJSSBasket.Items.Offers.DiscountRules
{
    internal class AppleTenPercentDiscount : ISpecialOfferRule
    {
        public Basket Evaluate(Basket basket)
        {
            var apples = new Apples();
            
            if (basket.CheckBasketContains(apples)) { Apples.price = Apples.price / 1.10m; }
            
            return basket;
            
        }

        public bool OfferActive()
        {
            return true;
        }
    }
}
