using System;
class Factorial
{
    public static void Main(String[] args)
    {
        //FActorial using while loop
        Console.Write("Enter a natural number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number < 0)
        {
            Console.WriteLine("Factorial is not defined for negative numbers.");
            return;
        }
        int factorial = 1;
        while (number >= 1)
        {
            factorial *= number;
            number--;
        }
        Console.WriteLine("The factorial of is: " + factorial);
    }
}