using System;
class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
        for(int j = 0; j < n-1; j++)
        {
            int min_idx=j;
            for(int k = j + 1; k < n; k++)
            {
                if (arr[k] < arr[min_idx])
                {
                    min_idx=k;
                }
            }
            int temp = arr[j];
            arr[j]=arr[min_idx];
            arr[min_idx]=temp;
            Console.WriteLine(string.Join(" ",arr));
        }
        Console.WriteLine();
        Console.Write("Sorted Array: ");
        for(int o = 0; o < arr.Length; o++)
            {
                Console.Write(arr[o]+" ");
            }
    }
}