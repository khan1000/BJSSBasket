using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJSSBasket.Items.Offers
{
    internal interface ISpecialOfferRule
    {
        Basket Evaluate(Basket basket);
        bool OfferActive();
    }
}
