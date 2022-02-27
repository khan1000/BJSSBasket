using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJSSBasket
{
    internal class ConsoleIO
    {
        private string[]? _args { get; set; }  
        
        public ConsoleIO()
        {
            //this._args = args;
        }

        public void printArgs() 
        {
            foreach (var arg in _args) { Console.WriteLine(arg); }
            
        }

        public void feedArgs()
        {
            var arg = Console.ReadLine();

            _args = arg.Split(" ");
        
        }

    }
}
