using System;
class NoOfHandshake
{
    public static void Main(String[] args)
    {
        Console.Write("Enter the no. of students: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"The total no of handshake between {number} students are {CalculateHandshake(number)}");
    }
    public static int CalculateHandshake(int number)
    {
        int handshake = (number*(number-1))/2;
        return handshake;
    }
}