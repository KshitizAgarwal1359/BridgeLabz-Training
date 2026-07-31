using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.BankSystem
{
    internal class Program1
    {
        static void Main(String[] args)
        { 
                Bank bank = new Bank("Pune Branch", "DENA000X156");
                bank.DisplayBankDetails();

                Menu menu = new Menu();
                menu.Start();
            
        }
    }
}
