using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.SmartHomeAutomation
{
    class Program
    {
        public static void Main(String[] args)
        {
            Appliance[] appliances =
            {
                new Light("Bathroom Light"),
                new Fan("Bedroom Fan"),
                new AC("Living Room")
            };
            foreach (Appliance appliance in appliances)
            {
                appliance.TurnOn();
                appliance.TurnOff();
                Console.WriteLine();
            }
        }
    }
}
