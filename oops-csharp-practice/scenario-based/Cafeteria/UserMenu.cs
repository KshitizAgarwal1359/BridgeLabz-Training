using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Cafeteria
{
    internal class UserMenu
    {
        public MenuManager menuManager;
        public UserMenu(MenuManager menuManager)
        {
            this.menuManager= menuManager;
        }
        public void ShowUserMenu() //shows menu to user
        {
            Order order = new Order();
            string choice;
            while (true)
            {
                Console.WriteLine("User Menu");
                Console.WriteLine("1. View Menu");
                Console.WriteLine("2. Order Item");
                Console.WriteLine("3. Checkout");
                Console.Write("Choose: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        menuManager.DisplayMenu();
                        break;
                    case "2":
                        OrderItem(order);
                        break;
                    case "3":
                        order.PrintBill();
                        return;
                    default:
                        Console.WriteLine("Invalid Choice");
                        return;
                }
            }
        }
        public void OrderItem(Order order) //take  and add the items which are ordered by user
        {
            menuManager.DisplayMenu();
            Console.Write("Enter item index: ");
            int index = Convert.ToInt32(Console.ReadLine());
            if(index>=0 && index < menuManager.menuItems.Length && menuManager.menuItems[index] != null)
            {
                order.orderedItems.Add(menuManager.menuItems[index]);
                Console.WriteLine("Item added.");
            }
            else
            {
                Console.WriteLine("Invalid item");
            }
        }
    }
}
