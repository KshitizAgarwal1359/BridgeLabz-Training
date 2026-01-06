using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.VehicleRentalApplication
{
    public sealed class Truck : Vehicle // Truck classinherits from Vehicle , sealed to prevent further inheritance
    {
        public Truck(string vehicleNumber) : base(vehicleNumber, 7500) { }

        public override double CalculateRent(int days)
        {
            return rentPerDay*days+3000; //+3000 for security and heavy duty vehicle charge
        }
    }
}
