using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.Scenario_Based.FurnitureManufacturing
{
    class ScenarioA
    {
        public static void Execute()
        {
            WoodPrice wood = new WoodPrice();
            int maxRevenue = WoodOptimizer.CalculateMaxRevenue(wood.priceChart, wood.rodLength);
            Console.WriteLine("Optimized max reveniue: " + maxRevenue);
        }
    }
}
