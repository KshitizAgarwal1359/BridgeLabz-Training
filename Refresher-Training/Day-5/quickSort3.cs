using System;
class Program
{
    public static void Main()
    {
        int[] arr = {1,212,34,45};
        string sorted = isSortedAfterOnePass(arr);
        Console.WriteLine(sorted);
    }
            public static string isSortedAfterOnePass(int[] arr)
    {
        int pivot = arr[arr.Length-1];
        int i=0;
        for(int j = 0; j < arr.Length-1; j++)
        {
            int temp = arr[i];
            arr[i]= arr[j];
            arr[j] = temp;
            i++;
        }
        int temp2 = arr[i];
        arr[i]=arr[arr.Length-1];
        arr[arr.Length-1]=temp2;
        for(int k = 0; k < arr.Length-1; k++)
        {
            if (arr[k] > arr[k + 1])
            {
                return "NO";
            }

        }
        return "YES";
    }
}