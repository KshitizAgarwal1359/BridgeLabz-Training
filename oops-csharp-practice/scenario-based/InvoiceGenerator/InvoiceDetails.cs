using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.InvoiceGenerator
{
    internal class InvoiceDetails
    {
        public string InvoiceNumber { get; set; } = "";
        public string IssuerName { get; set; } = "";
        public DateTime InvoiceDate { get; set; }
        public string CustomerName { get; set; } = "";
        public PaymentMode PaymentMode {  get; set; }
        public PaymentStatus PaymentStatus { get; set; }

    }
}
