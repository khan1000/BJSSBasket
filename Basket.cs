using BJSSBasket.Items;
using BJSSBasket.Items.Offers;
using System.Linq;

namespace BJSSBasket
{
    public class Basket
    {
        private List<IItem> _basket { get; set; }


        public Basket(IItem item)
        {
            _basket = new List<IItem>();

        }

        public Basket()
        {
            _basket = new List<IItem>();
        }

        public void Additem(IItem item)
        {
            _basket.Add(item);

        }

        public decimal Subtotal()
        {
            decimal subtotal = 0;

            foreach (var item in _basket) { subtotal += item.intsancePrice; }

            return subtotal;
        }

        //helper methods for cheking in dicount rules
        
        public bool CheckBasketContains(IItem item) 
        {
            return _basket.Contains(item);
        }

        public int CountItemFreqency(IItem item) 
        {
            return _basket.Count(x => x == item);
        }

        //attempt at a rule engine doesn't work :(
        public Basket ApplyDiscounts(Basket basket) 
        {
            var bastketWithDiscounts = new SpecialOfferService().ProcessDiscount(basket);

            return bastketWithDiscounts;
        
        }

        //apply apple 10% discount
        public bool ApplyAppleDiscounts() 
        {
            bool discountActive = false; 
            
            foreach (var item in _basket) 
            { 
                if (item is Apples) 
                { 
                    item.intsancePrice = item.intsancePrice / 1.10m;
                    discountActive = true;
                } 
            }
            
            return discountActive;

        }

        //apply 2 for half price rules
        public bool ApplyTinBreadDiscount() 
        {
            bool discountActive = false;

            int soupnumber = 0;
            
            foreach (var item in _basket) { if (item is Soup) soupnumber++; }

            if (soupnumber >= 2) 
            {
                discountActive = true;
                foreach (var item in _basket) { if (item is Bread) { item.intsancePrice = item.intsancePrice / 2m; }; }
            }

            return discountActive;
        }

        public decimal Total() 
        {
            decimal total = 0;
            
            ApplyAppleDiscounts();

            foreach (var item in _basket) { total += item.intsancePrice; }

            return total;
        }


        

        //private bool CheckForApples() 
        //{
        //    foreach(var item in _basket) { if (item is Apples) return true; }

        //    return false;
        
        //}
        


       // public decimal Total() {  }




    }
}
