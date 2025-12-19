using System;
class AveragePercentage{
	public static void Main(){
		//Calculation of avg of Sam's marks in PCM
		int mathsMarks=94;
		int physicsMarks=95;
		int chemistryMarks=96;
		double averageMarksPercentage=((mathsMarks+physicsMarks+chemistryMarks)/300.0)*100;
		Console.WriteLine("Sam's average mark in PCM is "+averageMarksPercentage);
		
	}
}