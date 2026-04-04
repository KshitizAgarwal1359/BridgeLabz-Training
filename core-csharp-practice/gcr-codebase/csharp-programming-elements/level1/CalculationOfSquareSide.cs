using System;
class CalculationOfSquareSide{
	public static void Main(String[] args){
		Console.Write("Enter the perimeter of Square: ");
		double perimeter = Convert.ToDouble(Console.ReadLine());
		double sideOfSquare = perimeter/4.0;
		Console.WriteLine($"The length of the side is {sideOfSquare} whose perimeter is {perimeter}");
	}
}