//tell the passenger the total distance he travelled in a bus.
using System;
class BusTracker
{
    public static void Main(String[] args)
    {
        double totalDistance = 0; //total distance travelled by the the passenger
        string option;
        Console.WriteLine("Bus distance tracking begins.");
        while (true)
        {
            Console.WriteLine("\n-----Menu-------");
            Console.WriteLine("1. Add distance at stop.");
            Console.WriteLine("2. View distance travelled.");
            Console.WriteLine("3. Exit.");
            Console.Write("Enter any follow up option: ");
            option = Console.ReadLine();
            switch (option) //switch function to choose option
            {
                case "1":
                Console.WriteLine("Enter the distance covered at this stop(in km)");
                double distance = Convert.ToDouble(Console.ReadLine());
                totalDistance+=distance;
                Console.Write("Distance added.\n");
                break;
                case "2":
                Console.WriteLine($"Total distance travelled: {totalDistance}");
                break;
                case "3":
                Console.WriteLine("Passenger exit the bus.");
                Console.WriteLine("Total distance travelled:"+totalDistance);
                return;
                default:
                Console.WriteLine("Invalid option entered.");
                break;
            }
        }
    }
}