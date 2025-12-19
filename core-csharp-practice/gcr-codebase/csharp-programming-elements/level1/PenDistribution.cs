using System;
class PenDistribution{
	public static void Main(){
		int numberOfPen = 14;
		int numberOfStudent = 3;
		int remainingPen = numberOfPen%numberOfStudent;
		int eachStudentPen = numberOfPen/numberOfStudent;
		Console.WriteLine($"The pen per Student is {eachStudentPen} and the remaining not distributed is {remainingPen}");
	}
}