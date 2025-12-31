using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.BankSystem
{
    internal class BankManager
    {
        public BankAccount CreateAccount()
        {
            Console.Write("Enter Account Number: ");
            int accNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Holder Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Initial Balance: ");
            double balance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Set ATM PIN: ");
            int pin = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Account created successfully.");
            return new BankAccount(accNo, name, balance, pin);
        }
        public void CheckBalance(BankAccount account)
        {
            if (!account.isActive)
            {
                Console.WriteLine("Account closed.");
                return;
            }
            Console.WriteLine("Balance: " + account.balance);
        }
        public void AddMoney(BankAccount account) {
            Console.WriteLine("Enter amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            if (amount <= 0)
            {
                Console.WriteLine("Enter valid amount.");
                return;
            }
        account.balance+= amount;
            Console.WriteLine("Money added by manager.");
        }
        public void RemoveMoney(BankAccount account) {
            Console.WriteLine("Enter amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            if (amount > account.balance) {
                Console.WriteLine("Cannot deduct insufficient balance.");
                return;
            }
            account.balance -= amount;
            Console.WriteLine("Amount deducted by manager.");
        }
        public void RemoveAccount(BankAccount account) { 
        account.isActive = false;
            Console.WriteLine("Account deleted");
        }
    }
}
