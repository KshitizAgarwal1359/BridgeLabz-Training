using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.SmartHomeAutomation
{
    class Fan : Appliance
    {
        public Fan(string name) : base(name) { }
        public override void TurnOn()
        {
            Console.WriteLine($"{Name} fan is turned on");
        }
        public override void TurnOff()
        {
            Console.WriteLine($"{Name} fan is turned off.");
        }
    }
}
