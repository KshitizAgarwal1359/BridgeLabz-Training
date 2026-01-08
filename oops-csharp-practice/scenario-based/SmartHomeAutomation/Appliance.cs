using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.SmartHomeAutomation
{
    abstract class Appliance : IControllable
    {
        public string Name { get; set; }
        protected Appliance(string name)
        {
            Name = name;
        }
        public abstract void TurnOn();
        public abstract void TurnOff();

    }
}
