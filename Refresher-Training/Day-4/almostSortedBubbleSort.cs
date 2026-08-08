using System;
class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter Size of array: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the elements of array: ");
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
        int[] sorted = (int[])arr.Clone();
        for(int i = 0; i < n - 1; i++)
        {
            for(int j = 0; j < n - i; j++)
            {
                if (sorted[j] > sorted[j + 1])
                {
                    int temp = sorted[j];
                    sorted[j]=sorted[j+1];
                    sorted[j+1]=temp;
                }
            }
        }
        int first = -1 , last =-1, count =0;
        for(int i = 0; i < n; i++)
        {
            if (arr[i] != sorted[i])
            {
                count++;
                if(first==-1)
                first=i;
            last=i;
            }
        }
        if (count == 0)
        {
            Console.WriteLine("already sorted");
        }
        else if (count == 2)
        {
            Console.WriteLine($"swap {first+1} {last+1}");
        }
        else
        {
            int[] temp = (int[])arr.Clone();
            int l=first,r=last;
            while (l < r)
            {
                int t = temp[l];
                temp[l]= temp[r];
                temp[r]=t; 
                l++;
                r--;
            }
            bool same = true;
            for(int i = 0; i < n; i++)
            {
                if (temp[i] != sorted[i])
                {
                    same=false;
                    break;

                }
            }
            if (same)
            {
                Console.WriteLine($"reverse {first+1} {last+1}");
            }
            else
            Console.WriteLine("no");
        }
    }
}