using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.Scenario_Based.AadharNumberManagement
{
    public interface IAadharSorter
    {
        void Sort(AadharRecord[] records); //defines sorting behaviour
    }
}
