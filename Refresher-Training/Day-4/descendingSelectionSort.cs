using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
        int comparisons =0;
        for(int i = 0; i < n - 1; i++)
        {
            int maxIndex = i;
            for(int j = i + 1; j < n; j++)
            {
                comparisons++;
                if (arr[j] > arr[maxIndex])
                {
                    maxIndex=j;
                }
            }
            int temp = arr[i];
            arr[i]=arr[maxIndex];
            arr[maxIndex]=temp;
        }
        Console.WriteLine(string.Join(" ",arr));
        Console.WriteLine($"Comparisons: {comparisons}");
    }
}