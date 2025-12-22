using System;
class SignCheck
{
    public static void Main(String[] args)
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0)
        {
            Console.WriteLine("The number is Positive");
        }
        else if (number < 0)
        {
            Console.WriteLine("The number is Negative");
        }
        else
        {
            Console.WriteLine("The number is Zero");
        }
    }
}