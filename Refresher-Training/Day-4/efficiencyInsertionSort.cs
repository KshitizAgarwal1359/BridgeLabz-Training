using System;
class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(); 
        int n = int.Parse(input[0]);
        int k = int.Parse(input[1]);
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
        int comparisons = 0;
        for(int i = 1; i < n; i++)
        {
            int key = arr[i];
            int j=i-1;
            while (j >= 0)
            {
                comparisons++;
                if (arr[j] > key)
                {
                    arr[j+1]=arr[j];
                    j--;
                }
                else
                {
                    break;
                }
            }
            arr[j+1]=key;
        }
        Console.WriteLine(string.Join(" ",arr));
        Console.WriteLine($"Comparisons: {comparisons}");
    }
}