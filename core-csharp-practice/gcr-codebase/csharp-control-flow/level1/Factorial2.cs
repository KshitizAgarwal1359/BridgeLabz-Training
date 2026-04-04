using System;
class Factorial2
{
    public static void Main(String[] args)
    {
        //Factorial using for loop
        Console.Write("Enter a natural number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number < 0)
        {
            Console.WriteLine("Factorial is not defined for negative numbers.");
            return;
        }
        int factorial = 1;
        for (int i = number; i >= 1; i--)
        {
            factorial *= i;
        }
        Console.WriteLine("The factorial is: " + factorial);
    }
}