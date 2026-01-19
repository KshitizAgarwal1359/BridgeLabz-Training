using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.Scenario_Based.ParcelTracker
{
    class ParcelTrackerImpl : IParcelTracker
    {
        private StageNode head;
        public ParcelTrackerImpl()
        {
            head = null;
        }
        public void AddStage(string stageName) //add a stage at end
        {
            StageNode newNode = new StageNode(stageName);
            if (head == null)
            {
                head = newNode;
                return;
            }
            StageNode current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
        public void AddCheckpointAfter(string existingStage,string newStage) //add a intermediate point
        {
            StageNode current = head;
            while (current != null)
            {
                if (current.StageName.Equals(existingStage))
                {
                    StageNode newNode = new StageNode(newStage);
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    return;
                }
                current = current.Next;
            }
            Console.WriteLine($"Checkpoint '{existingStage}' is not here");
        }
        public void TrackParcel() //forward tracking
        {
            if (head == null)
            {
                Console.WriteLine("Parcel lost. no tracking info found.");
                return;
            }
            StageNode current = head;
            Console.WriteLine("Parcel Tracking status: ");
            while (current != null)
            {
                Console.Write(current.StageName);
                if (current.Next != null)
                {
                    Console.Write("=>");
                }
                current = current.Next;
            }
            Console.WriteLine("\n");
        }
    }
}
