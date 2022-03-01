namespace BJSSBasket // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main()
        {
            //try 
            //{ 
            //    var consoleArgs = Console.ReadLine(); 
            //}
            //catch (Exception ex) 
            //{
            //    Console.WriteLine("somthing went wrong");
            //    Console.WriteLine(ex);
            //    Environment.Exit(1);
            //}

            bool endapp = false;



            while (endapp == false)
            {
                LineReader app = new LineReader();

                app.begin();
                try
                {
                    app.feedArgs(Console.ReadLine().Trim());
             
                    app.argToItem();
                    app.writeSubtotal();
                    //app.applyDiscounts();   
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("please input");
                    
                    continue;
                }
                catch (ArgumentException ex) 
                { 
                    Console.WriteLine($"one or more of the flowing items does not exist: {ex.Message}");
                    continue;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                   
                    continue;
                }


               
                app.printArgs();

            }
        }

    



    }
}