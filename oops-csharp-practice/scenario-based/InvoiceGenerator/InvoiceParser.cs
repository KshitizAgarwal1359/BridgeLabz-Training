using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.InvoiceGenerator
{
    internal class InvoiceParser
    {
        public static List<InvoiceItem> ParseInvoice(string input)
        {
            List<InvoiceItem> items = new List<InvoiceItem>();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invoice input cannot be empty.");
                return items;
            }

            string[] tasks = input.Split(',');

            foreach (string task in tasks)
            {
                string trimmedTask = task.Trim();

                // Expected formats:
                // "Samosa - 50 INR"
                // "Samosa 50 INR"

                string description = "";
                int amount = 0;

                if (trimmedTask.Contains("-"))
                {
                    // Format: Name - Amount INR
                    string[] parts = trimmedTask.Split('-');

                    if (parts.Length != 2)
                    {
                        Console.WriteLine($"Invalid task format: {trimmedTask}");
                        continue;
                    }

                    description = parts[0].Trim();
                    amount = ExtractAmount(parts[1]);
                }
                else
                {
                    // Format: Name Amount INR
                    string[] parts = trimmedTask.Split(' ');

                    if (parts.Length < 2)
                    {
                        Console.WriteLine($"Invalid task format: {trimmedTask}");
                        continue;
                    }

                    description = parts[0].Trim();
                    amount = ExtractAmount(trimmedTask);
                }

                items.Add(new InvoiceItem
                {
                    Description = description,
                    Amount = amount
                });
            }

            return items;
        }

        private static int ExtractAmount(string text)
        {
            string number = "";

            foreach (char c in text)
            {
                if (char.IsDigit(c))
                    number += c;
            }

            return int.TryParse(number, out int value) ? value : 0;
        }
    }
}
