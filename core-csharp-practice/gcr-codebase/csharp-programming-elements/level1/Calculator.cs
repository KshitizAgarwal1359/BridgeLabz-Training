using System;
class Calculator{
	public static void Main(){
		Console.Write("Enter 1st number:");
		int num1 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter 2nd number:");
		int num2 = Convert.ToInt32(Console.ReadLine());
		int addition = num1+num2;
		int sub = num1-num2;
		int multiply = num1*num2;
		int division = num1/num2;
		Console.WriteLine($"The addition, subtraction, multiplication and division value of 2 numbers {num1} and {num2} is {addition}, {sub} , {multiply}, and {division}");
		
	}
}