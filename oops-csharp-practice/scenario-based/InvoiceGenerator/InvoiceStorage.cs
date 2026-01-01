using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.InvoiceGenerator
{
    internal class InvoiceStorage
    {
        private const string FilePath = "invoice.txt";
        public static void Save(string invoiceText)
        {
            File.WriteAllText(FilePath, invoiceText);
        }
        public static void Load()
        {
            if (!File.Exists(FilePath))
            {
                Console.WriteLine("No previous invoice found.");
                return;
            }
            Console.WriteLine("\n=====previous invoice====");
            Console.WriteLine(File.ReadAllText(FilePath));
        }
        
    }
}
