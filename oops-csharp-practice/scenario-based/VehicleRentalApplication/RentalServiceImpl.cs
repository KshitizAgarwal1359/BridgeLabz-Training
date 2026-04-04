using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.VehicleRentalApplication
{
    public class RentalServiceImpl //carry rental workflow logic
    {
        public static void RentVehicle()//static method to handle vehicle rent process
        {
            Console.Write("Enter customer name: "); //input of customer details
            string name = Console.ReadLine();
            Console.WriteLine("Enter license number: ");
            string license = Console.ReadLine();
            Customers customer = new Customers(name, license);
            Console.WriteLine("Select vehicle type: "); //display vehicle option
            Console.WriteLine("1. Bike");
            Console.WriteLine("2. Car");
            Console.WriteLine("3. Truck");
            int choice = int.Parse(Console.ReadLine());
            Console.Write("Enter vehicle number: "); //collect vehicle details
            string vehicleNumber = Console.ReadLine();
            Console.Write("Enter rental days: ");
            int days = int.Parse(Console.ReadLine());
            Vehicle vehicle;
            switch (choice) //object created based on user choice
            {
                case 1:
                    vehicle = new Bike(vehicleNumber);
                    break;
                case 2:
                    vehicle = new Car(vehicleNumber);
                    break;
                case 3: vehicle = new Truck(vehicleNumber); break;
                default: Console.WriteLine("Invalid option."); return;
            }
            double totalRent = vehicle.CalculateRent(days); //rent calculation
            Console.WriteLine("\nRENTAL DETAILS"); //display rent details
            Console.WriteLine($"Customer Name: {customer.name}");
            Console.WriteLine($"Vehicle Number: {vehicle.VehicleNumber}");
            Console.WriteLine($"Rental Days: {days}");
            Console.WriteLine($"Total Rent: {totalRent}");
        }
    }
}
