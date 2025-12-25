using System;
class RandomNumberAnalysis
{
    public static int[] Generate4DigitRandomArray(int size)
    {
        int[] numbers = new int[size];
        Random random = new Random();
        for(int i = 0; i < size; i++)
        {
            numbers[i]=random.Next(1000,10000);
        }
        return numbers;
    }
    public static double[] FindAverageMinMax(int[] numbers)
    {
        int sum=0;
        int min=numbers[0];
        int max=numbers[0];
        foreach(int num in numbers)
        {
            sum+=num;
            min=Math.Min(min,num);
            max=Math.Max(max,num);
        }
        double average=(double)sum/numbers.Length;
        return new double[] {average,min,max};
    }
    public static void Main(string[] args)
    {
        int size=5;
        int[] randomNumbers=Generate4DigitRandomArray(size);
        Console.WriteLine("Generated four digits numbers:");
        foreach(int num in randomNumbers)
        {
            Console.Write(num+" ");
        }
        double[] result=FindAverageMinMax(randomNumbers);
        Console.WriteLine("Average value:"+result[0]);
        Console.WriteLine($"min val: {result[1]}");
        Console.WriteLine($"Max value: {result[2]}");
    }
}