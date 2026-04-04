using System;
class TotalIncome
{
    public static void Main()
    {
        Console.Write("Enter the salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the bonus: ");
        double bonus = Convert.ToDouble(Console.ReadLine());
        double totalIncome = salary + bonus;
        Console.WriteLine($"The Total Income is {totalIncome}");
    }
}