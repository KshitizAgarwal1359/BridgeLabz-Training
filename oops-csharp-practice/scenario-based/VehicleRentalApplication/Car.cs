using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.VehicleRentalApplication
{
    public class Car : Vehicle // Car class inherits from vehicle
    {
        public Car(string vehicleNumber) : base(vehicleNumber, 800) { } //custructor to assign fix car rent

        public override double CalculateRent(int days) //overrides Calculaterent method
        {
            Console.WriteLine("₹500 will be extra for security purposes.");
            return rentPerDay * days+500; //+500 for security purpose
        }

    }
}
