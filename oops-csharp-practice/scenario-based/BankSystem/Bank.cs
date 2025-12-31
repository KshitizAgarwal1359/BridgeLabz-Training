using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.BankSystem
{
    internal class Bank
    {
        public const string BankName = "Dena Bank";
        public string BranchName;
        public string IFSCCode;
        public Bank(string branchName, string iFSCCode)
        {
            BranchName = branchName;
            IFSCCode = iFSCCode;
        }
        public void DisplayBankDetails()
        {
            Console.WriteLine("\n---------Bank Details-----------");
            Console.WriteLine("Bank Name: " + BankName);
            Console.WriteLine("Branch Name: " + BranchName);
            Console.WriteLine("IFSC Code: "+IFSCCode);
        }
    }
}
