using System;
class NumberAnalyzer
{
    static bool IsPositive(int number)
    {
        return number>=0;
    }
    static bool IsEven(int number)
    {
        return number%2==0;
    }
    static int Compare(int num1,int num2)
    {
        if (num1 > num2)
        return 1;
        else if(num1==num2)
        return 0;
        else
        return -1;
    }
    public static void Main(String[] args)
    {
        int[] numbers=new int[5];
        for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"ENter number {i+1}: ");
            numbers[i]=Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("number analysis: ");
        for(int i = 0; i < numbers.Length; i++)
        {
            if (IsPositive(numbers[i]))
            {
                if(IsEven(numbers[i]))
                Console.WriteLine($"{numbers[i]} is positive.");
                else
                Console.WriteLine($"{numbers[i]} is positive and odd.");
            }
            else
            Console.WriteLine($"{numbers[i]} is negative.");
        }
        int result = Compare(numbers[0],numbers[numbers.Length-1]);
        Console.WriteLine("Comparison:");
        if (result == 1)
        {
            Console.WriteLine("1st element> last");
        }
        else if(result==0)
        Console.WriteLine("1st element==last element");
        else
        Console.WriteLine("1st element == last element.");
    }
}