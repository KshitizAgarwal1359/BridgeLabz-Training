using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.Scenario_Based.AadharNumberManagement
{
    public class AadharManagerMenu
    {
        public static void Show()
        {
            AadharRecord[] records = new AadharRecord[]
            {
                new AadharRecord(123456789090),
                new AadharRecord(123456789012),
                new AadharRecord(123456789067),
                new AadharRecord(123456789034)
            }; //initiallizing aadhar data
            IAadharSorter sorter = new RadixSort(); //creates sorter
            AadharManager manager = new AadharManager(records, sorter); //creates manager
            Console.WriteLine("Before sorting: ");
            manager.DisplayAadharNumbers(); //dispalying unsorted aadhars
            manager.SortAadharNumbers(); //sorts aadhar numbers
            Console.WriteLine("\nAfter sorting: ");
            manager.DisplayAadharNumbers(); //displaying sorted aadhars

            //for scenario b
            Console.WriteLine("\nEnetr aadhar to search: ");
            long target = long.Parse(Console.ReadLine());
            int index = manager.SearchAadharNumber(target);
            if (index != -1)
            {
                Console.WriteLine($"Aadhar number found at index: {index}");
            }
            else
            {
                Console.WriteLine("Aadhar number not found");
            }
            Console.WriteLine("\n Enetr prefix to dispaly Aadhar no.: ");
            string prefix = Console.ReadLine();
            Console.WriteLine($"\nAadhar no. with prefix {prefix} :");
            manager.DisplayByPrefix(prefix);
        }
    }
}
