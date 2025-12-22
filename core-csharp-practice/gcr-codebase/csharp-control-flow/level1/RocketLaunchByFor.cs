using System;
class RocketLaunchByFor{
	public static void Main(String[] args){
		// using the for loop for the count down for the rocket Launch
		Console.Write("Enter the number for countdown: ");
		int number = Convert.ToInt32(Console.ReadLine());
		for(int i=number;i>=1;i--){
			Console.WriteLine(i);
		}
	}
}