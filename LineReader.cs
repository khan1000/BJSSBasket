using BJSSBasket.Items;

namespace BJSSBasket
{
    public class LineReader
    {
        private string[]? _args { get; set; }


        private Basket _basket = new Basket();

        public void begin()
        {
            Console.Write("PriceBasket:");

        }

        public void printArgs()
        {

            foreach (var arg in _args) { Console.WriteLine( $"{arg}"); }

        }

        public void feedArgs(string args)
        {
            
            if (args == null || args == "") throw new ArgumentNullException();

            string arg = args;

            _args = arg.Split(" ");
           
        }

        public void argToItem()
        {
            foreach (var arg in _args)
            {
                try
                {
                    _basket.Additem(ItemFactory.createItem(arg));
                }
                catch (ArgumentException) 
                {
                    throw;
                }

            }
           
        }

        public void writeSubtotal() 
        {
            Console.WriteLine($"Subtotal: £{_basket.Subtotal()} \n");
        }


        public void writeTotal()
        {
            decimal subtotal = _basket.Subtotal();
            

            var appleDiscountActive = _basket.ApplyAppleDiscounts();
            var breadDiscountActive = _basket.ApplyTinBreadDiscount();
            

            decimal postDiscountSubtotal = _basket.Subtotal();

            if (appleDiscountActive) { Console.WriteLine($"Apples 10% off: -£{(subtotal - Decimal.Round(postDiscountSubtotal, 2)):F2} \n"); }

            if (breadDiscountActive) { Console.WriteLine($"For 2 Soup tin get 50% off bread!: -£{(subtotal - Decimal.Round(postDiscountSubtotal, 2)):F2} \n"); }

            if (!appleDiscountActive && !breadDiscountActive) { Console.WriteLine("(no offers availble) \n"); }

            Console.WriteLine($"Total: £{_basket.Subtotal():F2}");
        }




    }
}
