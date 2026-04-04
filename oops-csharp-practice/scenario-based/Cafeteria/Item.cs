using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Cafeteria
{
    internal class Item //class to store cafeteria menu items and price
    {
        public string Name;
        public double Price;
        public Item(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
