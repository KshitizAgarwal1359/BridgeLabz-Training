using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.Scenario_Based.ParcelTracker
{
    class ParcelTrackerMain
    {
        public static void Main(string[] args)
        {
            IParcelTracker parcelTracker = new ParcelTrackerImpl();
            parcelTracker.AddStage("Packed"); //default delivery stages
            parcelTracker.AddStage("Shipped");
            parcelTracker.AddStage("In transit");
            parcelTracker.AddStage("Out for delivery");
            parcelTracker.AddStage("Delivered");
            parcelTracker.AddCheckpointAfter("Shipped", "Hold dur to bad weather"); //adding custom checkpoint
            parcelTracker.TrackParcel(); //track parcel
        }
    }
}
