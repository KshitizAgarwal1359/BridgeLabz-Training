using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.Scenario_Based.MetalFactoryPipeCutting
{
    class MetalFactoryMenu
    {
        public static void Start()
        {
            string option;
            do
            {
                Console.WriteLine("---Metal factory pipe cutting---");
                Console.WriteLine("1. Optimized revenue");
                Console.WriteLine("2. Custom length order");
                Console.WriteLine("3. Non-Optimized revenue");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");
                option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        ScenarioA.Execute();
                        break;
                    case "2":
                        ScenarioB.Execute();
                        break;
                    case "3":
                        ScenarioC.Execute();
                        break;
                    case "4":
                        Console.WriteLine("Exiting");
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            } while (option != "4");
        }
    }
}
