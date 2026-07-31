using System;
class RocketLaunch{
	public static void Main(String[] args){
		//Using a while loop for a countdown for a rocket launch
		Console.Write("Enter the number for the count down: ");
		int number = Convert.ToInt32(Console.ReadLine());
		while(number>=1){
			Console.WriteLine(number);
			number--;
		}
	}
}