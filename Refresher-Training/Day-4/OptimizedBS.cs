using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
        int passes = 0;
        for(int i = 0; i < n - 1; i++)
        {
            bool swapped = false;
            passes++;
            for(int j = 0; i < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j]=arr[j+1];
                    arr[j+1]=temp;
                    swapped=true;
                }
            }
            if (!swapped)
            {
                break;
            }
        }
        Console.WriteLine(passes);
    }
}