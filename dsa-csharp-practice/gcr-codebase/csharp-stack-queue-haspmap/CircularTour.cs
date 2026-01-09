using System;
class CircularTour
{
    public static void Main(String[] args)
    {
        int[] petrol = { 4, 6, 7, 4 };
        int[] distance = { 6, 5, 3, 5 };
        int startIndex = FindStartingPoint(petrol, distance);
        if (startIndex == -1)
            Console.WriteLine("No possible circular tour");
        else
            Console.WriteLine("Start at petrol pump index: " + startIndex);
    }
    static int FindStartingPoint(int[] petrol, int[] distance)
    {
        int start = 0;
        int surplus = 0;
        int deficit = 0;
        for (int i = 0; i < petrol.Length; i++)
        {
            surplus += petrol[i] - distance[i];
            if (surplus < 0)
            {
                deficit += surplus;
                surplus = 0;
                start = i + 1;
            }
        }
        return (surplus + deficit >= 0) ? start : -1;
    }
}
