using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.Scenario_Based.MetalFactoryPipeCutting
{
    class ScenarioB
    {
        public static void Execute()
        {
            RodPrice rod = new RodPrice();
            Console.Write("enter custom length: ");
            int customLength = int.Parse(Console.ReadLine());
            Console.Write("Enter custom price: ");
            int customPrice = int.Parse(Console.ReadLine());
            if (customLength > rod.rodLength || customLength <= 0)
            {
                Console.WriteLine("Invalid Custom length.Rod Length is only" + rod.rodLength);
                return;
            }
            if (customLength <= rod.rodLength) //price chart update for custom length
            {
                rod.priceChart[customLength] = customPrice;
            }
            int newRevenue = RodOptimizer.CalculateMaxRevenue(rod.priceChart, rod.rodLength);
            Console.WriteLine("Revenue after custom order: " + newRevenue);
        }
    }
}
