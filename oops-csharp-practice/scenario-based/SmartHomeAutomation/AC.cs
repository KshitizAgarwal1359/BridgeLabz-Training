using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.SmartHomeAutomation
{
    class AC : Appliance
    {
        public AC(string name) : base(name) { }
        public override void TurnOn()
        {
            Console.WriteLine($"{Name} AC in turned on on 24C.");
        }
        public override void TurnOff()
        {
            Console.WriteLine($"{Name} AC is turned off.");
        }
    }
}
