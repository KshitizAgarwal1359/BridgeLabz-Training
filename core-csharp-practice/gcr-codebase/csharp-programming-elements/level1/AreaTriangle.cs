using System;
class AreaTriangle
{
	public static void Main(String[] args)
	{
	    Console.Write("Enter base of triangle in inches : ");
		double triangleBase = Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter height of triangle in inches: ");
		double triangleHeight = Convert.ToDouble(Console.ReadLine());
		double areaInSqInches = 0.5 * triangleBase * triangleHeight;
		double areaInSqCentimeter = areaInSqInches * 6.4516; //multiply by 6.4516 to convert into SqCentimeter
		Console.WriteLine($"Area of triangle in square inches: {areaInSqInches:F2}");
		Console.WriteLine($"Area of triangle in square centimeters: {areaInSqCentimeter:F2}");
	}
}