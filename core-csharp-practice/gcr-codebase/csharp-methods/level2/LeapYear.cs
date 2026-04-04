//if a year after 1582 is a leap year or not
using System;
class LeapYear
{
    static bool LeapCheck(int number)
    {
        if (number < 1582)
        {
            return false;
        }
        if (number % 400 == 0)
        {
            return true;
        }
        if(number%4==0 && number % 100 != 0)
        {
            return true;
        }
        return false;
    }
    public static void Main(String[] args)
    {
        Console.Write("Enter the year: ");
        int year = Convert.ToInt32(Console.ReadLine());
        if (year < 1582)
        {
            Console.WriteLine("leap year calculation is valid after year 1582");
            return;
        }
        bool isLeap = LeapCheck(year);
        if(isLeap)
        {
            Console.WriteLine("It is leap year.");
        }
        else
        {
            Console.WriteLine("It is not a leap year.");
        }
    }
}
