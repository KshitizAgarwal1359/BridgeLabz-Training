using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.Scenario_Based.MetalFactoryPipeCutting
{
    class ScenarioC
    {
        public static void Execute()
        {
            RodPrice rod = new RodPrice();
            int revenueWithoutCut = rod.priceChart[rod.rodLength]; //non optimized strategy sell rod as whole
            Console.WriteLine("Revenue without optimization: " + revenueWithoutCut);
        }
    }
}
