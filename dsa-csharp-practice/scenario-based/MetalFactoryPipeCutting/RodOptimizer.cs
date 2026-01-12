using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.Scenario_Based.MetalFactoryPipeCutting
{
    class RodOptimizer
    {
        public static int CalculateMaxRevenue(int[] priceChart,int rodLength) //revenue calculation
        {
            int[] revenue = new int[rodLength + 1];
            revenue[0] = 0;
            for(int i = 1; i <= rodLength; i++)
            {
                int max = priceChart[i];
                for(int j = 1; j < i; j++)
                {
                    int currentValue = priceChart[j] + revenue[i - j]; //trying all possible cuts and pick max revenue
                    if (currentValue > max)
                    {
                        max= currentValue;
                    }
                }
                revenue[i] = max;
            }
            return revenue[rodLength];
        }
    }
}
