using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BJSSBasket.Items.Offers.DiscountRules;

namespace BJSSBasket.Items.Offers
{
    internal class SpecialOfferService
    {
        public Basket ProcessDiscount(Basket basket) 
        {
            var ruletype = typeof(ISpecialOfferRule);

            var ruleType = typeof(ISpecialOfferRule);
            IEnumerable<ISpecialOfferRule> rules = this.GetType().Assembly.GetTypes()
                .Where(p => ruleType.IsAssignableFrom(p) && !p.IsInterface)
                .Select(r => Activator.CreateInstance(r) as ISpecialOfferRule);
            
            var engine = new SpecialOffersEngine(rules);
            return engine.CalculateOffer(basket);


        }


    }
}
