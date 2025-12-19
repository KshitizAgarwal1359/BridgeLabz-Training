using System;
class KilometersToMiles{
	public static void Main(){
		Console.Write("Enter the distance in km: ");
		double kilometer = Convert.ToDouble(Console.ReadLine());
		double miles = kilometer/1.6;
		Console.WriteLine($"The total miles is {miles} mile for the given {kilometer} km");
	}
}