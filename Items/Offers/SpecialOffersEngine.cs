using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJSSBasket.Items.Offers
{
    internal class SpecialOffersEngine
    {
        private readonly IEnumerable<ISpecialOfferRule> _rules;

        public SpecialOffersEngine(IEnumerable<ISpecialOfferRule> rules)
        {
            _rules = rules;
        }

        public Basket CalculateOffer(Basket basket) 
        {
            foreach (var rule in _rules) 
            {
                if(rule.OfferActive()) basket = rule.Evaluate(basket);
 
            }
            return basket;
        }
    }
}
