using BJSSBasket.Items;

namespace BJSSBasket
{
    public class Basket
    {
        private List<IItem> _basket { get; set; }

        public Basket()
        {
            _basket = new List<IItem>();
        }

        public void Additem(IItem item)
        {
            _basket.Add(item);

        }
        //raw price without discounts
        public decimal Subtotal()
        {
            decimal subtotal = 0;

            foreach (var item in _basket) { subtotal += item.intsancePrice; }

            return subtotal;
        }


        //apply apple 10% discount
        public bool ApplyAppleDiscounts()
        {
            bool discountActive = false;

            foreach (var item in _basket)
            {
                if (item is Apples)
                {
                    item.intsancePrice = Decimal.Round(item.intsancePrice / 1.10m, 1);
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

            ApplyTinBreadDiscount();

            total = Subtotal();

            return total;
        }

        //for testing purposes
        public void Emptybaseket()
        {
            _basket.Clear();
        }






    }
}
