using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.Scenario_Based.FurnitureManufacturing
{
    class ScenarioC
    {
        public static void Execute()
        {
            WoodPrice wood = new WoodPrice();
            int bestRevenue = WoodOptimizer.CalculateRevenueWithMinWaste(wood.priceChart, wood.rodLength);
            Console.WriteLine("Best Revenue with minimal waste: " + bestRevenue);
        }
    }
}
