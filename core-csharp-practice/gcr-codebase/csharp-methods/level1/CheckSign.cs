using System;
class CheckSign
{
    public static void Main(String[] args)
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"the number is {SignDetermination(number)}");
    }
    public static string SignDetermination(int number)
    {
        if (number > 0)
        {
            return "positive";
        }
        else if (number < 0)
        {
            return "negative";
        }
        return "zero";
    }
}