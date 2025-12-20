using System;
class DistributionOfChocolate
{
    public static void Main(String[] args)
    {
        Console.Write("Enter the number of students: ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the number of chocolates: ");
        int numberOfChocolates = Convert.ToInt32(Console.ReadLine());
        int chocolatesPerStudent = numberOfChocolates / numberOfStudents;
        int remainingChocolates = numberOfChocolates % numberOfStudents;
        Console.WriteLine($"The number of chocolate each student gets is {chocolatesPerStudent} and the number of remaining chocolates is {remainingChocolates}");
    }
}