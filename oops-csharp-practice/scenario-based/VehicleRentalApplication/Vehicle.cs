using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.VehicleRentalApplication
{
    public abstract class Vehicle : IRentable
    {
        protected string vehicleNumber; //protected fields allow acces in derived classes
        protected double rentPerDay;
        public string VehicleNumber //public member to access vehicle number
        {
            get { return vehicleNumber; }
            set { vehicleNumber = value; }
        }
        public double RentPerDay //public member
        {
            get { return rentPerDay; }
            set { rentPerDay = value; }
        }
        protected Vehicle(string vehicleNumber,double rentPerDay) //contructor intializes vehicle details
        {
            this.vehicleNumber = vehicleNumber;
            this.rentPerDay= rentPerDay;
        }
        public abstract double CalculateRent(int days); //abstract method forces derived classes to implement their own rent calculation logic
    }
}
