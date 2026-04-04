using System;
class CarRental
{
    public string customerName;
    public string carModel;
    public int rentalDays;
    public double totalCost;
    public CarRental() // default constr.
    {
        customerName="Unknown";
        carModel="Sedan";
        rentalDays=1;
        totalCost=rentalDays*1500; // default value
    }
    public CarRental(string cn,string cm,int d)
    {
        customerName=cn;
        carModel=cm;
        rentalDays=d;
        totalCost=CalculateCost();
    }
    public double CalculateCost()
    {
        double rateDay = 0;
        if(carModel=="Hatchback")
        rateDay=1000;
        else if(carModel=="Sedan")
        rateDay=1500;
        else if(carModel=="SUV")
        rateDay=2000;
        else
        rateDay=1400;
        return rateDay*rentalDays;
    }
    public void Display()
    {
        Console.WriteLine("Customer name: "+customerName);
        Console.WriteLine("car model: "+carModel);
        Console.WriteLine($"no. of Rental days: {rentalDays}");
        Console.WriteLine($"Total cost: {totalCost}\n");
    }
    public static void Main(String[] args)
    {
        CarRental car = new CarRental();
        car.Display();
        CarRental car1= new CarRental("Kshitiz","SUV",5);
        car1.Display();
    }
}