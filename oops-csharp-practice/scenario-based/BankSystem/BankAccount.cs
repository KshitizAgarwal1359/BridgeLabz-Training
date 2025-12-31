using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.BankSystem
{
    internal class BankAccount
    {
        public int accountNumber;
        public string holderName;
        public double balance;
        public int pin;
        public bool isActive;
        public BankAccount(int accNo,string name,double initialBalance,int Pin)
        {
            accountNumber = accNo;
            holderName = name;
            balance = initialBalance;
            pin = Pin;
            isActive = true;
        }
        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid deposit amount");
                return;
            }
            balance += amount;
            Console.WriteLine("Deposit Successfull");
        }
        public void Withdraw(double amount) {
            if (amount > balance)
            {
                Console.WriteLine("Insufficient balance.");
                return;
            }
            balance -= amount;
            Console.WriteLine("Withdraw Successfull");
        }
        public void CheckBalance() {
            Console.WriteLine("Your account balance is ₹:" + balance);
        }
        public void ChangePin(int oldPin, int newPin)
        {
            if (oldPin != pin)
            {
                Console.WriteLine($"wrong pin");
                return;
            }
            pin = newPin;
            Console.WriteLine("Pin changed.");
        }
    }
}
