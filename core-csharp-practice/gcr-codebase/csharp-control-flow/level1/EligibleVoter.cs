using System;
class EligibleVoter
{
    public static void Main(String[] args)
    {
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        if(age >= 18)
        {
            Console.WriteLine("The person can vote.");
        }
        else
        {
            Console.WriteLine("The person cannot vote.");
        }
    }
}