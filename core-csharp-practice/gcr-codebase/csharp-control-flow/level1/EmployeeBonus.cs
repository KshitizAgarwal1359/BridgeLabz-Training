using System;
class EmployeeBonus
{
    public static void Main(String[] args)
    {
        //calculating employee bonus based on years of service
        Console.Write("Enter the salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the years of service: ");
        int yearsOfService = Convert.ToInt32(Console.ReadLine());
        double bonus = 0;
        if(yearsOfService > 5)
        {
            bonus = 0.05 * salary;
        }
        Console.WriteLine("The bonus amount: " + bonus);
    }
}