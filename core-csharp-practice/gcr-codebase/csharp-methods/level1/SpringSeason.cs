using System;
using System.Transactions;
class SpringSeason
{
    public static void Main(String[] args)
    {
        Console.Write("Enter the month no. (1-12): ");
        int month = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the day no. (1-31): ");
        int day = Convert.ToInt32(Console.ReadLine());
        if(month<1 ||month>12 || day<1 || day > 31)
        {
            Console.WriteLine("Invalid date or month");
            return;
        }
        bool isSpring = SpringCheck(month,day);
        if (isSpring)
        {
            Console.WriteLine("Its a spring season.");
        }
        else
        {
            Console.WriteLine("Not a spring season.");
        }
    }
    public static bool SpringCheck(int month,int day)
    {
        if((month==3 && day>=20) || (month==4) || (month==5) || (month==6 && day<=20))
        {
            return true;
        }
        return false;
    }
}