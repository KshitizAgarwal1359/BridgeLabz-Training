using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.LinkedList.InventoryManagementSystem
{
    class Program
    {
        public static void Main(String[] args)
        {
            InventoryLinkedList inventory = new InventoryLinkedList();
            inventory.AddAtBeginning(101, "Keyboard", 10, 500);
            inventory.AddAtEnd(102, "Mouse", 20, 300);
            inventory.AddAtEnd(103, "Monitor", 5, 8000);
            inventory.AddAtPosition(2, 104, "Laptop", 3, 55000);
            Console.WriteLine("\nInventory Items:");
            inventory.DisplayAllItems();
            Console.WriteLine("\nUpdate Quantity:");
            inventory.UpdateQuantity(102, 25);
            Console.WriteLine("\nSearch by Item Name:");
            inventory.SearchByItemName("Laptop");
            Console.WriteLine("\nTotal Inventory Value:");
            inventory.CalculateTotalValue();
            Console.WriteLine("\nSort by Price (Descending):");
            inventory.SortInventory("price", false);
            inventory.DisplayAllItems();
            Console.WriteLine("\nRemove Item:");
            inventory.RemoveByItemId(101);
            Console.WriteLine("\nFinal Inventory:");
            inventory.DisplayAllItems();
        }
    }
}
