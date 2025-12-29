// a 2d array of weekly and 24 hours temperature 
//find the hottest and coldest day
//find the average temperature of each day.
using System;
class TemperatureAnalysis
{
    static string[] daysOfWeek={"Sunday","Monday","Tuesday","Wednesday","Thursday","Friday","Saturday"};
    public static void Main(String[] args)
    {
        float[,] weekData = GenerateTemperature();
        AnalyzeTemperature(weekData);
    }
    public static void AnalyzeTemperature(float[,] weekData)
    {
        float[] averageTempDaily = new float[7];
        for(int i = 0; i < 7; i++)
        {
            float dailySum =0;
            for(int j = 0; j < 24; j++)
            {
                dailySum+=weekData[i,j];
            }
            averageTempDaily[i]=dailySum/24;
        }
        Console.WriteLine("Average daily temp. of the week is: ");
        for(int i = 0; i < 7; i++)
        {
            Console.WriteLine($"DAy {i+1}: {averageTempDaily[i]:F2} °C");
        }
        float maxGlobalTemp = float.MinValue;
        int hottestDayIndex=-1;
        float minGlobalTemp = float.MaxValue;
        int coldestDayIndex = -1;
        for(int i = 0; i < 7; i++)
        {
            for(int j = 0; j < 24; j++)
            {
                float currentTemperature = weekData[i,j];
                if (currentTemperature > maxGlobalTemp)
                {
                    maxGlobalTemp=currentTemperature;
                    hottestDayIndex=i;
                }
                if (currentTemperature < minGlobalTemp)
                {
                    minGlobalTemp=currentTemperature;
                    coldestDayIndex=i;
                }
            }
        }
        Console.WriteLine($"Hottest Day: {daysOfWeek[hottestDayIndex]} {maxGlobalTemp:F2} °C");
        Console.WriteLine($"Coldest Day: {daysOfWeek[coldestDayIndex]} {minGlobalTemp:F2} °C");
    }
    public static float[,] GenerateTemperature()
    {
        float[,] data = new float[7,24];
        Random random = new Random();
        for(int i = 0; i < 7; i++)
        {
            for(int j = 0; j < 24; j++)
            {
                data[i,j]=0f +(float)random.NextDouble()*50f;  //generating random temperature between 15 deg cel to 50 deg cel
            }
        }
        return data;
    }
}