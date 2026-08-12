using System;
class Program
{
    static void merge(int[] arr,int l,int m,int r)
    {
        int n1 = m-l+1;
        int n2 = r-m;
        int[] L = new int[n1];
        int[] R = new int[n2];
        for(int a = 0; a < n1; ++a)
        {
            L[a]=arr[l+a];
        }
        for(int b = 0; b < n2; ++b)
        {
            R[b]=arr[m+1+b];
        }
        int i=0, j=0;
        int k = l;
        while(i<n1 && j < n2)
        {
            if (L[i] <= R[j])
            {
                arr[k]=L[i];
                i++;
            }
            else
            {
                arr[k]=R[j];
                j++;
            }
            k++;
        }
        while (i < n1)
        {
            arr[k]=L[i];
            i++;
            k++;
        }
        while (j < n2)
        {
            arr[k]=R[j];
            j++;
            k++;
        }
    }
static void mergeSort(int[] arr, int l, int r)
{
    if (l < r)
    {
        int m = l + (r - l) / 2;

        mergeSort(arr, l, m);
        mergeSort(arr, m + 1, r);
        merge(arr, l, m, r);
    }
}
    static void Main()
    {
        int[] arr = {38,23,12,45,43,89};
        Console.Write("Original Array: ");
        Console.Write(string.Join(" ",arr));
        mergeSort(arr,0,arr.Length-1);
        Console.WriteLine();
        Console.Write("Sorted Array: ");
        Console.Write(string.Join(" ",arr));
    }
}