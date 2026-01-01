using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Cafeteria
{
    internal class AdminMenu
    {
        public MenuManager menuManager;
        public AdminAuth auth;
        public AdminMenu(MenuManager menuManager)
        {
            this.menuManager = menuManager;
            auth = new AdminAuth();
        }
        public void ShowAdminMenu() //admin menu to set or view menu
        {
            if (!auth.Login())
            {
                Console.WriteLine("Invalid admin.");
                return;
            }
            string choice;
            while (true)
            {
                Console.WriteLine("Admin Menu");
                Console.WriteLine("1. Set Menu");
                Console.WriteLine("2. View Menu");
                Console.WriteLine("3. logout");
                Console.Write("Choose: ");
                choice= Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        SetMenu();
                        break;
                    case "2":
                        menuManager.DisplayMenu();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("invalid choice.");
                        break;
                }
            }
        }
        public void SetMenu() //method to set menu by admin
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"item {i} name: ");
                string name = Console.ReadLine();
                Console.WriteLine($"Item {i} price: ");
                double price = Convert.ToDouble(Console.ReadLine());
                menuManager.menuItems[i] = new Item(name, price);
            }
        }
    }
}
