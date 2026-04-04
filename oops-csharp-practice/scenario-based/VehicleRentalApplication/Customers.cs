using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.VehicleRentalApplication
{
    public class Customers //this class stores customer related details
    {
        public string name {  get; set; }
        public string licenseNumber { get; set; }
        public Customers(string Name, string LicenseNumber) //constructor initializes customer details
        {
            this.name = Name;
            this.licenseNumber = LicenseNumber;
        }
    }
}
