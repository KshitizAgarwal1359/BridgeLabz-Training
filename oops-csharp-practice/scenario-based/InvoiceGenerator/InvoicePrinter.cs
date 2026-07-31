using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.InvoiceGenerator
{
    internal class InvoicePrinter
    {
        public static string PrintInvoice(
         InvoiceDetails details,
         List<InvoiceItem> items,
         int totalAmount)
        {
            string invoice =
    $@"
=========== INVOICE ===========
Invoice No   : {details.InvoiceNumber}
Date         : {details.InvoiceDate}
Issuer       : {details.IssuerName}
Customer     : {details.CustomerName}
Payment Mode : {details.PaymentMode}
Status       : {details.PaymentStatus}

Item                     Amount
-------------------------------
";

            foreach (var item in items)
            {
                invoice += $"{item.Description,-25} {item.Amount}\n";
            }

            invoice +=
    @"-------------------------------
Total Amount: " + totalAmount + @" INR
===============================";

            Console.WriteLine(invoice);
            return invoice;
        }

    }
}
