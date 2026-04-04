using System;
class FootballTeamHeight
{
    static int FindSum(int[] heights)
    {
        int sum=0;
        foreach(int h in heights)
        {
            sum+=h;
        }
        return sum;
    }
    static double FindMean(int[] heights)
    {
        int sum=FindSum(heights);
        return (double)sum/heights.Length;
    }
    public static int FindShortest(int[] heights)
    {
        int min=heights[0];
        foreach(int h in heights)
        {
            if(h<min)
            min=h;
        }
        return min;
    }
    public static int FindTallest(int[] heights)
    {
        int max=heights[0];
        foreach(int h in heights)
        {
            if(h>max)
            max=h;
        }
        return max;
    }
    public static void Main(String[] args)
    {
        int[] heights=new int[11];
        Random random=new Random();
        for(int i = 0;i < heights.Length; i++)
        {
            heights[i]=random.Next(150,251);
        }
        Console.WriteLine("Heights of all players: ");
        foreach(int h in heights)
        {
            Console.Write(h+" ");
        }
        Console.WriteLine();
        Console.WriteLine("Shortest player height: "+FindShortest(heights)+"cm");
        Console.WriteLine("tallest player height: "+FindTallest(heights)+"cm");
        Console.WriteLine("mean of player height: "+FindMean(heights)+"cm");
    }
}