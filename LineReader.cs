using BJSSBasket.Items;

namespace BJSSBasket
{
    public class LineReader
    {
        private string[]? _args { get; set; }

        //public LineReader(string args)
        //{
        //    if (args == null) throw new ArgumentNullException("args");

        //    this._args = args.Split(" ");
        //}

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

        

        //public void writeTotal() 
        //{
        //    Console.WriteLine($"to");
        //}




    }
}
