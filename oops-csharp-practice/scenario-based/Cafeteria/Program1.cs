using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Cafeteria
{
    internal class Program1
    {
        public static void Main(string[] args)
        {
            MenuManager menuManager = new MenuManager();  //obect of menu manager
            AdminMenu adminMenu = new AdminMenu(menuManager); // object admin menu
            UserMenu userMenu = new UserMenu(menuManager); //object user menu
            int choice;
            do
            {
                Console.WriteLine("\n=== Cafeteria App ==="); //choice of login
                Console.WriteLine("1. Admin");
                Console.WriteLine("2. User");
                Console.WriteLine("3. Exit");
                Console.Write("Choose: ");

                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                    adminMenu.ShowAdminMenu(); //opens admin menu 
                else if (choice == 2)
                    userMenu.ShowUserMenu();  //opens user menu
            } while (choice != 3); //closes the program
        }
    }
}
