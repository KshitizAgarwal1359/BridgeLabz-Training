// Problem

// You are given two arrays that are already sorted in ascending order.

// Merge them into one sorted array.

// Do not sort the final array using a built-in sorting function.

// Input
// 5
// 1 3 5 7 9

// 4
// 2 4 6 8
// Output
// 1 2 3 4 5 6 7 8 9

using System;
class Program
{
    static void Main()
    {
        int n1 = int.Parse(Console.ReadLine());
        int[] arr1 = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
        int n2 = int.Parse(Console.ReadLine());
        int[] arr2 = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
        int[] result = new int[arr1.Length+arr2.Length];
        int i=0, j=0,k=0;
        while(i<arr1.Length && j < arr2.Length)
        {
            if (arr1[i] < arr2[j])
            {
                result[k]=arr1[i];
                k++;
                i++;
            }
            else
            {
                result[k]=arr2[j];
                k++;
                j++;
            }
        }
        while (i < arr1.Length)
        {
            result[k]=arr1[i];
            k++;
            i++;
        }
        while (j < arr2.Length)
        {
            result[k]=arr2[j];
            k++;
            j++;
        }
        Console.WriteLine(string.Join(" ",result));
    }
}