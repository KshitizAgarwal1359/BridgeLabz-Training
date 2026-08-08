using System;
class Program
{
    public static void Main()
    {
        int[] arr = {13,56,90,78,2,4};
        Console.Write("Original Array: ");
        for(int i=0;i<arr.Length;i++)
        {
            Console.Write(arr[i]+" ");
        }
        int n = arr.Length;
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
        }
        Console.WriteLine();
        Console.Write("Sorted Array: ");
        for(int o = 0; o < arr.Length; o++)
            {
                Console.Write(arr[o]+" ");
            }
    }
}