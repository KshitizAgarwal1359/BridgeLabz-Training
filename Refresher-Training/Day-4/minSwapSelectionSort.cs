using System;
class Program
{
    static void Main()
    {
        int n =int.Parse(Console.ReadLine());
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
        int swaps =0;
        for(int i = 0; i < n; i++)
        {
            while (arr[i] != i + 1)
            {
                int corrIndex=arr[i]-1;
                int temp = arr[i];
                arr[i]=arr[corrIndex];
                arr[corrIndex]=temp;
                swaps++;
            }
        }
        Console.WriteLine(swaps);
    }
}