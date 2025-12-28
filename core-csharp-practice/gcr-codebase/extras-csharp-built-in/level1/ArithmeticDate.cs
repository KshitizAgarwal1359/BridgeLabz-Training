//Problem 2: Date Arithmetic
using System;
class ArithmeticDate{
    public static void Main(string[] args){
    Console.Write("Enter a date (yyyy-MM-dd): ");
    string input = Console.ReadLine();
    DateTime date = Convert.ToDateTime(input);
    Console.WriteLine("Original Date: " + date.ToString("yyyy-MM-dd"));
    date = date.AddDays(7);   // Add 7 days
    Console.WriteLine("After adding 7 day" + date.ToString("yyyy-MM-dd"));
    date = date.AddMonths(1); // Add 1 month
    Console.WriteLine("After adding 1 month" + date.ToString("yyyy-MM-dd"));
    date = date.AddYears(2); // Add 2 years
    Console.WriteLine("After adding 2 year" + date.ToString("yyyy-MM-dd"));
    date = date.AddDays(-21); // Subtract 3 weeks (3 * 7 = 21 days)
    Console.WriteLine("After subtracting 3 week" + date.ToString("yyyy-MM-dd"));
}
}