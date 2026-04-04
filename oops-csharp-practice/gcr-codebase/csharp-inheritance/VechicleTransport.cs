using System;
class Vehicle{ // Superclass
  public int MaxSpeed;
  public string FuelType;
  public Vehicle(int maxSpeed, string fuelType){
    MaxSpeed = maxSpeed;
    FuelType = fuelType;
  }
  public virtual void DisplayInfo(){
    Console.WriteLine($"Max Speed: {MaxSpeed} km/h");
    Console.WriteLine($"Fuel Type: {FuelType}");
  }
}
class Car : Vehicle{ // Subclass — Car
    public int SeatCapacity;
    public Car(int maxSpeed, string fuelType, int seatCapacity): base(maxSpeed, fuelType){
      SeatCapacity = seatCapacity;
    }
    public override void DisplayInfo(){
      Console.WriteLine("\nVehicle Type: Car");
      base.DisplayInfo();
      Console.WriteLine($"Seat Capacity: {SeatCapacity}");
    }
}
class Truck : Vehicle{ // Subclass — Truck
  public int PayloadCapacity;
  public Truck(int maxSpeed, string fuelType, int payloadCapacity): base(maxSpeed, fuelType){
    PayloadCapacity = payloadCapacity;
  }
  public override void DisplayInfo(){
    Console.WriteLine("\nVehicle Type: Truck");
    base.DisplayInfo();
    Console.WriteLine($"Payload Capacity: {PayloadCapacity} kg");
  }
}
class Motorcycle : Vehicle{ // Subclass — Motorcycle
  public bool HasSidecar;
  public Motorcycle(int maxSpeed, string fuelType, bool hasSidecar): base(maxSpeed, fuelType){
    HasSidecar = hasSidecar;
  }
  public override void DisplayInfo(){
    Console.WriteLine("\nVehicle Type: Motorcycle");
    base.DisplayInfo();
    Console.WriteLine($"Has Sidecar: {HasSidecar}");
  }
}
class TransportSystem{ // Main Class
  public static void Main(string[] args){
    Vehicle[] vehicles = new Vehicle[]{
    new Car(180, "Petrol", 5),
    new Truck(120, "Diesel", 8000),
    new Motorcycle(160, "Petrol", false)};
    foreach (Vehicle v in vehicles){
    v.DisplayInfo();
    }
  }
}