using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.LinkedList.InventoryManagementSystem
{
    class InventoryNode
    {
        public int itemId;
        public string itemName;
        public int quantity;
        public double price;
        public InventoryNode next;
        public InventoryNode(int itemId, string itemName, int quantity, double price) //constructor to initialize item details
        {
            this.itemId = itemId;
            this.itemName = itemName;
            this.quantity = quantity;
            this.price = price;
            next = null;
        }
    }

}
