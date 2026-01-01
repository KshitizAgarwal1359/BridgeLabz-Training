using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.InvoiceGenerator
{
    internal class Menu
    {
        public static void ShowMenu()
        {
            InvoiceDetails details = new InvoiceDetails();
            List<InvoiceItem> items = null;
            while (true)
            {
                Console.WriteLine("\n========Invoice Generator==========");
                Console.WriteLine("1. Create Invoice");
                Console.WriteLine("2. Load Previous Invoice");
                Console.WriteLine("3. Exit.");
                Console.Write("Please choose a option: ");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1": //ask for basic invoice details
                        details.InvoiceNumber = "INV-" + DateTime.Now.Ticks;
                        details.InvoiceDate = DateTime.Now;
                        details.IssuerName = InputValidator.GetNonEmptyString("Isser NAme:");
                        details.CustomerName = InputValidator.GetNonEmptyString("Customer Name: ");
                        Console.WriteLine("Payment Mode: 1.Cash 2.UPI 3.Card 4.NetBanking");
                        details.PaymentMode = (PaymentMode)InputValidator.GetValidInt("Choose: ");
                        Console.WriteLine("Payment Status: 0. Paid 1. Pending 2. Partial");
                        details.PaymentStatus = (PaymentStatus)InputValidator.GetValidInt("Choose: ");
                        Console.WriteLine("Enter task: ");
                        string input = Console.ReadLine();
                        items = InvoiceParser.ParseInvoice(input);
                        int total = InvoiceCalculator.GetTotalAmount(items);
                        string invoiceText = InvoicePrinter.PrintInvoice(details, items, total);
                        InvoiceStorage.Save(invoiceText);
                        break;
                    case "2":
                        InvoiceStorage.Load();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Invalid Input.");
                        break;
                }

            }
        }
    }
}
