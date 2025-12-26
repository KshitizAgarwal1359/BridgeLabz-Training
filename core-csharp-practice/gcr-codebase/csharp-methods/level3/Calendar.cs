//display the calendar of the given month and year
using System;
class Calendar
{
    static string GetMonthName(int month)
    {
        string[] months =
        {"January", "February", "March", "April", "May", "June","July", "August", "September", "October", "November", "December"};  //storing month in array
        return months[month - 1];
    }
    static bool IsLeapYear(int year)
    {
    return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
    }
    static int GetDaysInMonth(int month, int year)
    {
        int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };  
        if (month == 2 && IsLeapYear(year))
            return 29;
        return days[month - 1];
    }
    static int GetFirstDay(int month, int year)
    {
        int d = 1;
        int y0 = year - (14 - month) / 12;    //algorithm to get first day of the month in tht year
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = month + 12 * ((14 - month) / 12) - 2;
        int d0 = (d + x + (31 * m0) / 12) % 7;
        return d0;
    }
    static void Main()
    {
        Console.Write("Enter month (1-12): ");
        int month = int.Parse(Console.ReadLine());
        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());
        string monthName = GetMonthName(month);
        int daysInMonth = GetDaysInMonth(month, year);
        int firstDay = GetFirstDay(month, year);
        Console.WriteLine($"   {monthName} {year}");
        Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");
        for (int i=0;i<firstDay;i++)
        {
            Console.Write("    ");
        }
        for (int day=1;day<=daysInMonth;day++)
        {
            Console.Write($"{day,3} ");
            if ((day + firstDay) % 7 == 0)
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
