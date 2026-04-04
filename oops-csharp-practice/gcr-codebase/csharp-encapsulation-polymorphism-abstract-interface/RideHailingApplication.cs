using System;
using System.Collections.Generic;
// Defines GPS-related behavior
interface IGPS
{
    string GetCurrentLocation();
    void UpdateLocation(string newLocation);
}
// Base class for all vehicles
abstract class Vehicle
{
    // Encapsulated fields
    private int vehicleId;
    private string driverName;
    private double ratePerKm;

    // Properties with controlled access
    public int VehicleId
    {
        get { return vehicleId; }
        private set
        {
            if (value <= 0)
                throw new ArgumentException("Vehicle ID must be positive");
            vehicleId = value;
        }
    }

    public string DriverName
    {
        get { return driverName; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Driver name cannot be empty");
            driverName = value;
        }
    }

    protected double RatePerKm
    {
        get { return ratePerKm; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("Rate per km must be positive");
            ratePerKm = value;
        }
    }

    // Constructor
    protected Vehicle(int vehicleId, string driverName, double ratePerKm)
    {
        VehicleId = vehicleId;
        DriverName = driverName;
        RatePerKm = ratePerKm;
    }

    // Abstract method
    public abstract double CalculateFare(double distance);

    // Concrete method
    public virtual void GetVehicleDetails()
    {
        Console.WriteLine($"Vehicle ID: {VehicleId}");
        Console.WriteLine($"Driver Name: {DriverName}");
        Console.WriteLine($"Rate per Km: {RatePerKm}");
    }
}
class Car : Vehicle, IGPS
{
    private string currentLocation = "Unknown";

    public Car(int id, string driver, double rate)
        : base(id, driver, rate) { }

    public override double CalculateFare(double distance)
    {
        return distance * RatePerKm; // Standard rate
    }

    public string GetCurrentLocation()
    {
        return currentLocation;
    }

    public void UpdateLocation(string newLocation)
    {
        currentLocation = newLocation;
    }
}
class Bike : Vehicle, IGPS
{
    private string currentLocation = "Unknown";

    public Bike(int id, string driver, double rate)
        : base(id, driver, rate) { }

    public override double CalculateFare(double distance)
    {
        return (distance * RatePerKm) * 0.9; // 10% cheaper
    }

    public string GetCurrentLocation()
    {
        return currentLocation;
    }

    public void UpdateLocation(string newLocation)
    {
        currentLocation = newLocation;
    }
}
class Auto : Vehicle, IGPS
{
    private string currentLocation = "Unknown";

    public Auto(int id, string driver, double rate)
        : base(id, driver, rate) { }

    public override double CalculateFare(double distance)
    {
        return (distance * RatePerKm) + 20; // Base charge
    }

    public string GetCurrentLocation()
    {
        return currentLocation;
    }

    public void UpdateLocation(string newLocation)
    {
        currentLocation = newLocation;
    }
}
class RideHailingApplication
{
    static void ProcessRides(List<Vehicle> vehicles, double distance)
    {
        foreach (Vehicle vehicle in vehicles)
        {
            vehicle.GetVehicleDetails();
            Console.WriteLine($"Distance: {distance} km");

            double fare = vehicle.CalculateFare(distance);
            Console.WriteLine($"Fare: ₹{fare}");

            if (vehicle is IGPS gps)
            {
                gps.UpdateLocation("City Center");
                Console.WriteLine($"Current Location: {gps.GetCurrentLocation()}");
            }

            Console.WriteLine("----------------------------------");
        }
    }

    static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car(101, "Rohit", 15),
            new Bike(102, "Aman", 10),
            new Auto(103, "Suresh", 12)
        };

        ProcessRides(vehicles, 8);
    }
}