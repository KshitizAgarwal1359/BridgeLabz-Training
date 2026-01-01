using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Cafeteria
{
    internal class MenuManager
    {
        public Item[] menuItems;
        public MenuManager()
        {
            menuItems = new Item[10];
        }
        public void DisplayMenu() //method to display cafeteria menu
        {
            Console.WriteLine("\n----------Cafeteria Menu----------");
            for (int i = 0; i < menuItems.Length; i++) {
                if (menuItems[i] != null) {
                    Console.WriteLine($"{i}. {menuItems[i].Name} - ₹{menuItems[i].Price}");

                }
                else
                {
                    Console.WriteLine(i+". Item not set.");
                }
            }
        }
    }
}
