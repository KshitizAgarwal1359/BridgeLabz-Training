using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.BankSystem
{
    internal class Menu
    {
        public BankAccount account;
        BankManager manager = new BankManager();
        BankClient client = new BankClient();
        public void Start() {
            string option;
            while(true)
            {
                Console.WriteLine("\n======Main Menu====");
                Console.WriteLine("1. Manager Login");
                Console.WriteLine("2. Client Login");
                Console.WriteLine("3. Exit");
                Console.Write("Choose from above option : ");
                option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        ManagerMenu();
                        break;
                    case "2":
                        if (account == null || !account.isActive)
                        {
                            Console.WriteLine("No active account.");
                        }
                        else
                        {
                            client.ClientMenu(account);
                        }
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Invalid Choice.");
                        break;
                }
            }

        }
        void ManagerMenu()
        {
            string option;
            while (true)
            {
                Console.WriteLine("\n=======Manager Menu=========");
                Console.WriteLine("1. Create Balance");
                Console.WriteLine("2. Check Balance");
                Console.WriteLine("3. Deposit money");
                Console.WriteLine("4. Remove Money");
                Console.WriteLine("5. Delete Account");
                Console.WriteLine("6. Logout");
                Console.WriteLine("Enetr choice: ");
                option = Console.ReadLine();
                switch (option) {
                    case "1":
                        account = manager.CreateAccount();
                        break;
                    case "2":
                        manager.CheckBalance(account);
                        break;
                    case "3":
                        manager.AddMoney(account);
                        break;
                    case "4":
                        manager.RemoveMoney(account);
                        break;
                    case "5":
                        manager.RemoveAccount(account);
                        break;
                    case "6":
                        return;

                }
            }
        }
    }
}
