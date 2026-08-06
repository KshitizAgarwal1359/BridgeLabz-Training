using System;
class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter Size of array: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the elements of array: ");
        int[] arr = new int[n];
        for(int i = 0; i < n; i++)
        {
            arr[i]=Convert.ToInt32(Console.ReadLine());
        }
    }
}