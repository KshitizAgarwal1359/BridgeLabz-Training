using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.LinkedList.InventoryManagementSystem
{
    class InventoryLinkedList
    {
        private InventoryNode head;
        public void AddAtBeginning(int itemId, string itemName, int quantity, double price)  // Add item at beginning
        {
            InventoryNode newNode = new InventoryNode(itemId, itemName, quantity, price);
            newNode.next = head;
            head = newNode;
        }
        public void AddAtEnd(int itemId, string itemName, int quantity, double price) // Add item at end
        {
            InventoryNode newNode = new InventoryNode(itemId, itemName, quantity, price);
            if (head == null)
            {
                head = newNode;
                return;
            }
            InventoryNode temp = head;
            while (temp.next != null)
                temp = temp.next;
            temp.next = newNode;
        }
        public void AddAtPosition(int position, int itemId, string itemName, int quantity, double price) // Add item at specific position (1-based index)
        {
            if (position <= 0)
            {
                Console.WriteLine("Invalid position.");
                return;
            }
            if (position == 1)
            {
                AddAtBeginning(itemId, itemName, quantity, price);
                return;
            }
            InventoryNode temp = head;
            for (int i = 1; i < position - 1 && temp != null; i++)
                temp = temp.next;
            if (temp == null)
            {
                Console.WriteLine("Position out of range.");
                return;
            }
            InventoryNode newNode = new InventoryNode(itemId, itemName, quantity, price);
            newNode.next = temp.next;
            temp.next = newNode;
        }
        public void RemoveByItemId(int itemId) // Remove item by Item ID
        {
            if (head == null)
            {
                Console.WriteLine("Inventory is empty.");
                return;
            }
            if (head.itemId == itemId)
            {
                head = head.next;
                Console.WriteLine("Item removed successfully.");
                return;
            }
            InventoryNode temp = head;
            while (temp.next != null && temp.next.itemId != itemId)
                temp = temp.next;
            if (temp.next == null)
            {
                Console.WriteLine("Item not found.");
                return;
            }
            temp.next = temp.next.next;
            Console.WriteLine("Item removed successfully.");
        }
        public void UpdateQuantity(int itemId, int newQuantity) // Update quantity by Item ID
        {
            InventoryNode temp = head;
            while (temp != null)
            {
                if (temp.itemId == itemId)
                {
                    temp.quantity = newQuantity;
                    Console.WriteLine("Quantity updated successfully.");
                    return;
                }
                temp = temp.next;
            }
            Console.WriteLine("Item not found.");
        }
        public void SearchByItemId(int itemId) // Search by Item ID
        {
            InventoryNode temp = head;
            while (temp != null)
            {
                if (temp.itemId == itemId)
                {
                    DisplayItem(temp);
                    return;
                }
                temp = temp.next;
            }
            Console.WriteLine("Item not found.");
        }
        public void SearchByItemName(string itemName) // Search by Item Name
        {
            InventoryNode temp = head;
            bool found = false;
            while (temp != null)
            {
                if (temp.itemName.Equals(itemName, StringComparison.OrdinalIgnoreCase))
                {
                    DisplayItem(temp);
                    found = true;
                }
                temp = temp.next;
            }
            if (!found)
                Console.WriteLine("Item not found.");
        }
        public void CalculateTotalValue() // Calculate total inventory value
        {
            double totalValue = 0;
            InventoryNode temp = head;
            while (temp != null)
            {
                totalValue += temp.price * temp.quantity;
                temp = temp.next;
            }
            Console.WriteLine($"Total Inventory Value: {totalValue}");
        }
        public void SortInventory(string sortBy, bool ascending) // Sort inventory by name or price
        {
            if (head == null || head.next == null)
                return;
            for (InventoryNode i = head; i != null; i = i.next)
            {
                for (InventoryNode j = i.next; j != null; j = j.next)
                {
                    bool shouldSwap = false;
                    if (sortBy.Equals("name", StringComparison.OrdinalIgnoreCase))
                    {
                        shouldSwap = ascending
                            ? string.Compare(i.itemName, j.itemName) > 0
                            : string.Compare(i.itemName, j.itemName) < 0;
                    }
                    else if (sortBy.Equals("price", StringComparison.OrdinalIgnoreCase))
                    {
                        shouldSwap = ascending
                            ? i.price > j.price
                            : i.price < j.price;
                    }
                    if (shouldSwap)
                    {
                        SwapData(i, j);
                    }
                }
            }
            Console.WriteLine("Inventory sorted successfully.");
        }
        private void SwapData(InventoryNode a, InventoryNode b) // Swap data between two nodes
        {
            (a.itemId, b.itemId) = (b.itemId, a.itemId);
            (a.itemName, b.itemName) = (b.itemName, a.itemName);
            (a.quantity, b.quantity) = (b.quantity, a.quantity);
            (a.price, b.price) = (b.price, a.price);
        }
        public void DisplayAllItems() // Display all items
        {
            if (head == null)
            {
                Console.WriteLine("Inventory is empty.");
                return;
            }
            InventoryNode temp = head;
            while (temp != null)
            {
                DisplayItem(temp);
                temp = temp.next;
            }
        }
        private void DisplayItem(InventoryNode item) // Display a single item
        {
            Console.WriteLine(
                $"ID: {item.itemId}, Name: {item.itemName}, Qty: {item.quantity}, Price: {item.price}"
            );
        }
    }
}
