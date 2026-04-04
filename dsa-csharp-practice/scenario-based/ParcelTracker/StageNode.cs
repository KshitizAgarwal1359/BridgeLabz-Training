using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.Scenario_Based.ParcelTracker
{
    class StageNode  //custom node class for the parcel stage 
    {
        public string StageName { get; set; }
        public StageNode Next { get; set; }
        public StageNode(string stageName)
        {
            StageName = stageName;
            Next = null;
        }
    }
}
