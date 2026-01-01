using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Cafeteria
{
    internal class Order
    {
        public List<Item> orderedItems = new List<Item>();
        public void PrintBill() //prints thge total amount bill
        {
            double total = 0;
            Console.WriteLine("\n========Bill===========");
            foreach(Item item in orderedItems)
            {
                Console.WriteLine($"{item.Name}-₹{item.Price}");
                total += item.Price;
            }
            Console.WriteLine("==============");
            Console.WriteLine($"Total Amount: ₹{total}");
        }
    }
}
