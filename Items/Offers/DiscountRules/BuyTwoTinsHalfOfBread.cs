using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJSSBasket.Items.Offers.DiscountRules
{
    internal class BuyTwoTinsHalfOfBread : ISpecialOfferRule
    {
        public Basket Evaluate(Basket basket)
        {
            var soup = new Soup();
            if (basket.CountItemFreqency(soup) >= 2) { Bread.price = Bread.price / 2 ; }

            return basket;
        }

        public bool OfferActive()
        {
            return true;
        }
    }
}
