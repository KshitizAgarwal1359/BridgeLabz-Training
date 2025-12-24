// finding smallest and largest between three numbers
using System;
class SmallestAndLargest
{
    public static void Main(String[] args)
    {
        Console.Write("Enter first number: ");
        int num1  = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        int num2  = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter third number: ");
        int num3  = Convert.ToInt32(Console.ReadLine());
        int[] result = FindSmallestAndLargest(num1,num2,num3);
        Console.WriteLine($"The smallest number is {result[0]} and largest number is {result[1]}");
    }
    public static int[] FindSmallestAndLargest(int number1,int number2,int number3)
    {
        int smallest, largest;
        if(number1<=number2 && number1<=number3)
        {
            smallest = number1;
        }
        else if(number2<=number1 && number2<=number3)
        {
            smallest = number2;
        }
        else
        {
            smallest = number3;
        }
        if(number1>=number2 && number1>=number3)
        {
            largest = number1;
        }
        else if(number2>=number1 && number2>=number3)
        {
            largest = number2;
        }
        else
        {
            largest = number3;
        }
        return new int[] {smallest, largest};
    }
}