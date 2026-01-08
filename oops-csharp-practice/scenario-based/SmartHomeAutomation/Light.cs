using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.SmartHomeAutomation
{
    class Light : Appliance
    {
        public Light(string name) : base(name) { }
        public override void TurnOn()
        {
            Console.WriteLine($"{Name} light is turned on with soft brightness");
        }
        public override void TurnOff()
        {
            Console.WriteLine($"{Name} light is turned off");
        }
    }
}
