using BridgeLabzDSA.Scenario_Based.MetalFactoryPipeCutting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BridgeLabzDSA.Scenario_Based.FurnitureManufacturing
{
    class FurnitureManufacturingMenu
    {
        public static void Start()
        {
            string option;
            do
            {
                Console.WriteLine("Custom furniture manufacturing");
                Console.WriteLine("1. Optimized revenue");
                Console.WriteLine("2. Revenue with waste constraint");
                Console.WriteLine("3. Revenue with minimal waste");
                Console.WriteLine("4. Exit");
                Console.Write("Enter Choice: ");
                option = Console.ReadLine();
                switch (option)
                {
                    case "1": ScenarioA.Execute(); break;
                    case "2": ScenarioB.Execute(); break;
                    case "3": ScenarioC.Execute(); break;
                    case "4": Console.WriteLine("Exiting."); break;
                    default: Console.WriteLine("Invalid choice."); break;
                }
            } while (option != "4");
        }
    }
}
