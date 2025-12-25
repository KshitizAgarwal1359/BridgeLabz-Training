using System;
class FriendsComparison
{
    static int FindYoungest(int[] ages)
    {
        int minIndex=0;
        for(int i = 1; i < ages.Length; i++)
        {
            if (ages[i] < ages[minIndex])
            {
                minIndex=i;
            }
        }
        return minIndex;
    }
    static int FindTallest(double[] heights)
    {
        int maxIndex=0;
        for(int i = 0; i < heights.Length; i++)
        {
            if (heights[i] > heights[maxIndex])
            {
                maxIndex=i;
            }
        }
        return maxIndex;
    }
    public static void Main(string[] args)
    {
        string[] names={"Amar","Akbar","Anthony"};
        int[] ages = new int[3];
        double[] heights=new double[3];
        for(int i = 0; i < 3; i++)
        {
            Console.Write($"enter age of {names[i]}");
            ages[i]=Convert.ToInt32(Console.ReadLine());
            Console.Write($"enter height if {names[i]} in cm: ");
            heights[i]=Convert.ToInt32(Console.ReadLine());
        }
        int youngestIndex=FindYoungest(ages);
        int tallestIndex=FindTallest(heights);
        Console.WriteLine($"Youngest friend: {names[youngestIndex]} age {ages[youngestIndex]}");
        Console.WriteLine($"tallest friend: {names[tallestIndex]} height: {heights[tallestIndex]}");
    }
}
