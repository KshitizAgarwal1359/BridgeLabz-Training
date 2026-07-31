/*: Eric travels from Chennai to Bangalore via Vellore. The distance from Chennai to Vellore is 156.6 km and the time taken is 4 hours 4 minutes. The distance from Vellore to Bangalore is 211.8 km and the time taken is 4 hours 25 minutes. Compute the total distance and total time from Chennai to Bangalore.
Create variables and take user inputs for name, fromCity, viaCity, toCity.
Create variables and take user inputs for distances: fromToVia and viaToFinalCity in miles.
Create variables and take the time taken for the journey.
Finally, print the results and try to understand operator precedence.
I/P => name, fromCity, viaCity, toCity, fromToVia, viaToFinalCity, timeTaken
O/P => The results of the trip are: ___, ___, and ___*/

using System;

public class EricTravels{
    public static void Main(string[] args){
    Console.Write("Enter your name: ");
    string name = Console.ReadLine();

    Console.Write("Enter the city you are traveling from: ");
    string fromCity = Console.ReadLine();

    Console.Write("Enter the city you are traveling via: ");
    string viaCity = Console.ReadLine();

    Console.Write("Enter the city you are traveling to: ");
    string toCity = Console.ReadLine();

    Console.Write($"Enter the distance (in miles) from {fromCity} to {viaCity}: ");
    double fromToVia = Convert.ToDouble(Console.ReadLine());

    Console.Write($"Enter the distance (in miles) from {viaCity} to {toCity}: ");
    double viaToFinalCity = Convert.ToDouble(Console.ReadLine());

    Console.Write($"Enter the time taken from {fromCity} to {viaCity} (hours): ");
    int hours1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter minutes: ");
    int minutes1 = Convert.ToInt32(Console.ReadLine());

    Console.Write($"Enter the time taken from {viaCity} to {toCity} (hours): ");
    int hours2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter minutes: ");
    int minutes2 = Convert.ToInt32(Console.ReadLine());

    double totalDistance = fromToVia + viaToFinalCity;
      int totalTime = (hours1 * 60 + minutes1) + (hours2 * 60 + minutes2);

    Console.WriteLine($"The Total Distance travelled by {name} from {fromCity} to {toCity} via {viaCity} is {totalDistance} miles and the Total Time taken is {totalTime} minutes");
    }
}