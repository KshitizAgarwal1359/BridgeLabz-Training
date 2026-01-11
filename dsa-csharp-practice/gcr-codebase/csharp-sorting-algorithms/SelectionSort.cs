using System;
class SelectionSortExamScores
{
    public static void Main(string[] args)
    {
        int[] examScores = { 78, 45, 92, 60, 85, 39, 70 }; //array of students' exam scores
        Console.WriteLine("Exam Scores Before Sorting:");
        PrintArray(examScores);
        SelectionSort(examScores); //call Selection Sort
        Console.WriteLine("\nExam Scores After Sorting (Ascending Order):");
        PrintArray(examScores);
    }
    public static void SelectionSort(int[] arr) //method to perform Selection Sort
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++) //move boundary of unsorted sub array
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++) //find the minimum element in remaining unsorted array
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }
            if (minIndex != i) //swap the found minimum element with first unsorted element
            {
                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
        }
    }
    public static void PrintArray(int[] arr) //method to print array elements
    {
        foreach (int score in arr)
        {
            Console.Write(score + " ");
        }
        Console.WriteLine();
    }
}
