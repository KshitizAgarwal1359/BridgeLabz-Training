using System;
class SwapNumbers
{
    public static void Main()
    {
        Console.Write("Enter first number: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        // Swapping the numbers
        int temp = firstNumber;
        firstNumber = secondNumber;
        secondNumber = temp;

        Console.WriteLine($"the swapped numbers are {firstNumber}, and {secondNumber}");
    }
}