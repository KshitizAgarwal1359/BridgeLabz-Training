using System;
class CountingSortStudentAges
{
    public static void Main(string[] args)
    {
        int[] ages = { 14, 12, 16, 10, 15, 13, 18, 12, 11, 14 }; //array of student ages (range: 10 to 18)
        Console.WriteLine("Student Ages Before Sorting:");
        PrintArray(ages);
        CountingSort(ages, 10, 18); //call Counting Sort
        Console.WriteLine("\nStudent Ages After Sorting (Ascending Order):");
        PrintArray(ages);
    }
    static void CountingSort(int[] arr, int minAge, int maxAge) //call Counting Sort
    {
        int range = maxAge - minAge + 1;
        int[] count = new int[range]; //Step 1:create count array
        for (int i = 0; i < arr.Length; i++) //Step 2:store frequency of each age
        {
            count[arr[i] - minAge]++;
        }
        for (int i = 1; i < count.Length; i++) //step 3:compute cumulative count
        {
            count[i] += count[i - 1];
        }
        int[] output = new int[arr.Length]; //step 4:create output array
        for (int i = arr.Length - 1; i >= 0; i--) //step 5:place elements in correct position
        {
            int age = arr[i];
            int index = count[age - minAge] - 1;
            output[index] = age;
            count[age - minAge]--;
        }
        for (int i = 0; i < arr.Length; i++) //step 6:copy sorted elements back to original array
        {
            arr[i] = output[i];
        }
    }
    public static void PrintArray(int[] arr)
    {
        foreach (int age in arr)
        {
            Console.Write(age + " ");
        }
        Console.WriteLine();
    }
}
