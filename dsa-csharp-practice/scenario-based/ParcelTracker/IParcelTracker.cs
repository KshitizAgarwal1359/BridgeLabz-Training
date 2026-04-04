using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BridgeLabzDSA.Scenario_Based.ParcelTracker
{
    interface IParcelTracker
    {
        void AddStage(string stageName);
        void AddCheckpointAfter(string existingStage, string newStage);
        void TrackParcel();
    }
}
