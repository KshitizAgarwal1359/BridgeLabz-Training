using System;
class Program
{
    static void Main()
    {
        int[] arr = {9,5,8,1,3};
        int pivotIndex = partitionArray(arr);
        Console.WriteLine("Partitioned Array: "+string.Join(" ",arr));
        Console.WriteLine("Pivot Index : "+pivotIndex);

    }
    public static int partitionArray(int[] arr)
    {
        int pivot  = arr[arr.Length-1];
        int i=0;
        for(int j = 0; j < arr.Length; j++)
        {
            if (arr[j] < pivot)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j]=temp;
                i++;
            }
        }
        int temp2=arr[i];
        arr[i]=arr[arr.Length-1];
        arr[arr.Length-1]=temp2;
        return i;
    }
}