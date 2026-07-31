using System;
class KilometerToMiles{
	public static void Main(){
		float kilometer = 10.8f; //given distance
		float miles = kilometer/1.6f; //convert kilometer into miles
		Console.WriteLine("The distance "+kilometer+" km in miles is "+miles);
	}
}