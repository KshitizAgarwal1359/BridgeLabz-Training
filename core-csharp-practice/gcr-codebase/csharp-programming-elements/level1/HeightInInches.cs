using System;
class HeightInInches{
	public static void Main(){
		Console.Write("Enter height in cm: ");
		double height = Convert.ToDouble(Console.ReadLine());
		double inInch = height/2.54;  //1 foot = 12 inches and 1 inch = 2.54 cm
		double inFeet = inInch/12;
		Console.WriteLine($"Your Height in cm is {height} while in feet is {inFeet:F2} and inches is {inInch:F2}");
	}
}