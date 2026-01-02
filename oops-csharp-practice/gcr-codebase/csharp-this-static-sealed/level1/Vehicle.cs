using System;

class Vehicle
{
    public static double RegistrationFee = 1500;     // static variable (shared registration fee)
    public readonly string RegistrationNumber;     // readonly variable (cannot be changed after initialization)
    public string OwnerName;     // instance variables
    public string VehicleType; 
    public Vehicle(string OwnerName, string VehicleType, string RegistrationNumber)     // Constructor using 'this' keyword
    {
        this.OwnerName = OwnerName;
        this.VehicleType = VehicleType;
        this.RegistrationNumber = RegistrationNumber;
    }
    public static void UpdateRegistrationFee(double newFee)     // static method to update registration fee
    {
        if (newFee > 0)
        {
            RegistrationFee = newFee;
        }
        else
        {
            Console.WriteLine("Invalid registration fee");
        }
    }
    public void DisplayVehicleDetails(object obj)     // Method using 'is' operator for safe type checking
    {
        if (obj is Vehicle)
        {
            Console.WriteLine("Owner Name : " + OwnerName);
            Console.WriteLine("Vehicle Type : " + VehicleType);
            Console.WriteLine("Registration Number: " + RegistrationNumber);
            Console.WriteLine("Registration Fee : ₹" + RegistrationFee);
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Invalid vehicle object");
        }
    }
}
class VehicleRegistrationSystem // Main class
{
    static void Main(string[] args)
    {
        Vehicle v1 = new Vehicle("Kshitiz", "Car", "MH12AB1234");
        Vehicle v2 = new Vehicle("Aman", "Bike", "DL05CD5678");
        v1.DisplayVehicleDetails(v1);
        v2.DisplayVehicleDetails(v2);
        Vehicle.UpdateRegistrationFee(2000);         // Update registration fee for all vehicles
        Console.WriteLine("After Updating Registration Fee:\n");
        v1.DisplayVehicleDetails(v1);
        v2.DisplayVehicleDetails(v2);
    }
}
