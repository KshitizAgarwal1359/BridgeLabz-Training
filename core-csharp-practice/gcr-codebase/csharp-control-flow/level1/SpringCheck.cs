using System;

class SpringCheck
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the day of the Month: ");
        int day = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the month in number format: ");
        int month = Convert.ToInt32(Console.ReadLine());

        if (month < 1 || month > 12 || day < 1 || day > 31)
        {
            Console.WriteLine("Invalid date");
            return;
        }

        bool isSpring =
            (month == 3 && day >= 20) ||
            (month == 4) ||
            (month == 5) ||
            (month == 6 && day <= 20);

        if (isSpring)
        {
            Console.WriteLine("Its a Spring Season");
        }
        else
        {
            Console.WriteLine("Not a Spring Season");
        }
    }
}
