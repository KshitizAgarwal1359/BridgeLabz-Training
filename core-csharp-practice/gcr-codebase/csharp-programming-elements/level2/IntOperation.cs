using System;
class IntOperation
{
    public static void Main()
    {
        Console.Write("Enter the three integer: ");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"the result of Int Operation are {a+b*c}, {a*b+c}, and {c+a/b} and {a%b+c}");
    }
}