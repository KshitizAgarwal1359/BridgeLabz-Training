// Demonstrate IndexOutOfRangeException for Arrays
using System;
class IndexExceptionArray
{
    public static void Main(String[] args)
    {
        int[] numbers = {1,2,3,4,5,6};
        int invalidIndex=11;
        try
        {
            int value = numbers[invalidIndex];
            Console.WriteLine(value);
        }
        catch(IndexOutOfRangeException e)
        {
            Console.WriteLine("IndexOutOfRangeException found");
            Console.WriteLine(e.Message);
        }
    }
}