using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BJSSBasket.Interfaces;

namespace BJSSBasket.Items
{
    internal class Soup : IItem, IDiscountable
    {
         public double price { get; set; }
         public bool isDiscountable { get ; set; }
    }
}
