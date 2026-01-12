using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.Scenario_Based.MetalFactoryPipeCutting
{
    class ScenarioA
    {
        public static void Execute()
        {
            RodPrice rod = new RodPrice();
            int maxRevenue = RodOptimizer.CalculateMaxRevenue(rod.priceChart, rod.rodLength);
            Console.WriteLine("Optimized max revenue: " + maxRevenue);
        }
    }
}
