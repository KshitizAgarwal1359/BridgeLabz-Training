using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.Scenario_Based.FurnitureManufacturing
{
    class WoodOptimizer
    {
        public static int CalculateMaxRevenue(int[] priceChart,int rodLength)
        {
            int[] revenue = new int[rodLength + 1];
            revenue[0] = 0;
            for(int i = 1; i <= rodLength; i++)
            {
                int maxValue = priceChart[i];
                for(int j = 1; j < i; j++)
                {
                    int currentValue = priceChart[j] + revenue[i - j];
                    if (currentValue > maxValue)
                    {
                        maxValue= currentValue;
                    }
                }
                revenue[i] = maxValue;
            }
            return revenue[rodLength];
        }
        public static int CalculateRevenueWithWaste(int[] priceChart,int rodLLength,int wasteLimit)
        {
            int usableLength = rodLLength - wasteLimit;
            if(usableLength <= 0)
            {
                return 0;
            }
            return CalculateMaxRevenue(priceChart, usableLength);
        }
        public static int CalculateRevenueWithMinWaste(int[] priceChart,int rodLength)
        {
            int bestRevenue = 0;
            for(int usedLength = rodLength; usedLength >= 1; usedLength--)
            {
                int currentRevenue = CalculateMaxRevenue(priceChart, usedLength);
                if (currentRevenue > bestRevenue)
                {
                    bestRevenue= currentRevenue;
                }
            }
            return bestRevenue;
        }
    }
}
