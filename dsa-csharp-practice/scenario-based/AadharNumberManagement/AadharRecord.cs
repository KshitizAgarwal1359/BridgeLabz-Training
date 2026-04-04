using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.Scenario_Based.AadharNumberManagement
{
    public class AadharRecord
    {
        public long AadharNumber { get; private set; } // stores 12 digit  aadhar no.
        public AadharRecord(long aadharNumber)
        {
            AadharNumber = aadharNumber;
        }
    }
}
