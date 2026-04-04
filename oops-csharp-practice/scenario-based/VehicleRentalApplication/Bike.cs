using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.VehicleRentalApplication
{
    public class Bike : Vehicle //bike class inherits vehicle class
    {
        public Bike(string vehicleNumber) : base(vehicleNumber, 300) { } //constructor assign fixe rent for vehicle
        public override double CalculateRent(int days) //overrides CalculateRent method
        {
            return rentPerDay * days;
        }
    }
}
