using System;

class AvgThreeNumber
{
    static void Main()
    {
        int num1 = 10;
        int num2 = 20;
        int num3 = 30;
        
        double average = (num1 + num2 + num3) / 3.0;
        
        Console.WriteLine($"Numbers: {num1}, {num2}, {num3}");
        Console.WriteLine($"Average: {average}");
    }
}