using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.Scenario_Based.FurnitureManufacturing
{
    class ScenarioB
    {
        public static void Execute()
        {
            WoodPrice wood = new WoodPrice();
            Console.WriteLine("Enter fixed waste length: ");
            int wasteLimit=int.Parse(Console.ReadLine());
            if (wasteLimit < 0 || wasteLimit >= wood.rodLength)
            {
                Console.WriteLine("Invalid Waste contraint.");
                return;
            }
            int revenueWithWaste = WoodOptimizer.CalculateRevenueWithWaste(wood.priceChart, wood.rodLength, wasteLimit);
            Console.WriteLine("Revenue after waste constraint: " + revenueWithWaste);
        }
    }
}
