using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.InvoiceGenerator
{
    internal class InvoiceCalculator
    {
        public static int GetTotalAmount(List<InvoiceItem> items)
        {
            int total = 0;
            foreach(InvoiceItem item in items)
            {
                total += item.Amount;
                
            }
            return total;
        }
    }
}
