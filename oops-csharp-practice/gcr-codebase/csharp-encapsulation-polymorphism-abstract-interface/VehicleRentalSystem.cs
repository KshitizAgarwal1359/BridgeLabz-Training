using System;
using System.Collections.Generic;
interface IInsurable
{
    double CalculateInsurance();
    string GetInsuranceDetails();
}
abstract class Vehicle
{
    private string vehicleNumber;
    private string type;
    protected double rentalRate;
    public string VehicleNumber
    {
        get{return vehicleNumber;}
        private set
        {
            if(string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("vehicle no. cannot be empty");
            vehicleNumber=value;
        }
    }
    public string Type
    {
        get{return type;}
        private set
        {
            if(string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("vehicle type cannot be empty");
            type=value;
        }
    }
    public double RentalRate
    {
        get{return rentalRate;}
        protected set
        {
            if(value<=0)
            throw new ArgumentException("Rental rate must be positive");
            rentalRate=value;
        }
    }
    protected Vehicle(string vehicleNumber,string type,double rentalRate)
    {
        VehicleNumber=vehicleNumber;
        Type=type;
        RentalRate=rentalRate;
    }
    public abstract double CalculateRentalCost(int days);
    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Vehicle no.: {VehicleNumber}");
        Console.WriteLine($"Type: {Type}");
        Console.WriteLine($"Rate per day: {RentalRate}");
    }
}
class Car: Vehicle, IInsurable
{
    private readonly string insurancePolicyNumber = "CAR-INS-345";
    public Car(string number,double rate):base(number,"Car",rate){}
    public override double CalculateRentalCost(int days)
    {
        return days*rentalRate;
    }
    public double CalculateInsurance()
    {
        return 500;
    }
    public string GetInsuranceDetails()
    {
        return $"Insurance Policy: {insurancePolicyNumber}";
    }
}
class Bike: Vehicle, IInsurable
{
    private readonly string insurancePolicyNumber="BIKE-INS-234";
    public Bike(string number,double rate):base(number,"Bike",rate){}
    public override double CalculateRentalCost(int days)
    {
        return days*rentalRate;
    }
    public double CalculateInsurance()
    {
        return 200;
    }
    public string GetInsuranceDetails()
    {
        return $"Insurance Policy: {insurancePolicyNumber}";
    }
}
class Truck: Vehicle, IInsurable
{
    private readonly string insurancePolicyNumber="TRUCK-9078-INS";
    public Truck(string number,double rate): base(number,"Truck",rate){}
    public override double CalculateRentalCost(int days)
    {
        return days*rentalRate+1000;
    }
    public double CalculateInsurance()
    {
        return 1000;
    }
    public string GetInsuranceDetails()
    {
        return $"Insurance Policy: {insurancePolicyNumber}";
    }
}
class VehicleRentalSystem
{
    public static void Main(String[] args)
    {
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car("AWESFG123",2200),
            new Bike("AWFTCG345",1200),
            new Truck("TFCVGY678",5600)
        };
        int days = 3;
        foreach(Vehicle vehicle in vehicles)
        {
            vehicle.DisplayDetails();
            double rentalCost = vehicle.CalculateRentalCost(days);
            Console.WriteLine($"Rental cost for {days} days: {rentalCost}");
            if(vehicle is IInsurable insurable)
            {
                Console.WriteLine(insurable.GetInsuranceDetails());
                Console.WriteLine($"Insurance Cost: {insurable.CalculateInsurance()}");
            }
            Console.Write("\n");
        }
    }
}