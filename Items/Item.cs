using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BJSSBasket.Interfaces;

namespace BJSSBasket.Items
{
    internal abstract class Item
    {
        public int Id { get; set; } 
        public string Name { get; set; }

    }
}
