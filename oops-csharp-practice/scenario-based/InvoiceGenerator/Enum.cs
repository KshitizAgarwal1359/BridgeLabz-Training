using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.InvoiceGenerator
{
    
    
        internal enum PaymentMode
        {
            Cash = 1,
            UPI,
            Card,
            NetBanking
        }

        internal enum PaymentStatus
        {
            Paid,
            Pending,
            Partial
        }

    
}
