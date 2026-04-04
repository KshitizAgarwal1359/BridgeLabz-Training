using System;
class YardsAndMiles{
	public static void Main(String[] args){
		Console.Write("Enter the distance in feet: ");
		double distanceFeet = Convert.ToDouble(Console.ReadLine());
		double yardDistance = distanceFeet/3.0;
		double milesDistance = yardDistance/1760.0;
		Console.WriteLine($"the distance of feet in {distanceFeet} in yards be {yardDistance} and miles will be {milesDistance}");
	}
}