using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.BankSystem
{
    internal class BankClient
    {
        public bool ValidatePin(BankAccount account)
        {
            Console.Write("Enter PIN: ");
            int Pin = Convert.ToInt32(Console.ReadLine());
            return Pin == account.pin;
        }
        public void ClientMenu(BankAccount account)
        {
            if (!ValidatePin(account))
            {
                Console.WriteLine("Invalid Pin.");
                return;
            }
            string option;
            while (true)
            {
                Console.WriteLine("\n=====Client Menu====");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit Cash");
                Console.WriteLine("3. Withdraw Cash");
                Console.WriteLine("4. Change Atm Pin");
                Console.WriteLine("5. Exit");
                Console.Write("Enetr choice");
                option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        account.CheckBalance();
                        break;
                    case "2":
                        Console.Write("Enter amount: ");
                        account.Deposit(Convert.ToDouble(Console.ReadLine()));
                        break;
                    case "3":
                        Console.Write("Enter amount: ");
                        account.Withdraw(Convert.ToDouble(Console.ReadLine()));
                        break;
                    case "4":
                        Console.Write("Enter old PIN: ");
                        int oldPin = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter new PIN: ");
                        int newPin = Convert.ToInt32(Console.ReadLine());
                        account.ChangePin(oldPin, newPin);
                        break;
                    case "5":
                        Console.WriteLine("Thank you.");
                        return;
                    default:
                        Console.WriteLine("Invalid Choice.");
                        break;
                }
            }
        }
    }
}
