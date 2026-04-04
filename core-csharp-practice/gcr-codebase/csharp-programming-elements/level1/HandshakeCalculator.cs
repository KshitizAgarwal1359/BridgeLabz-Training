using System;

class HandshakeCalculator
{
    public static void Main()
    {
        Console.Write("Enter number of students: ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());
        int maxHandshakes = (numberOfStudents*(numberOfStudents-1))/2;
        Console.WriteLine($"The maximum number of possible handshakes is {maxHandshakes}");
    }
}
