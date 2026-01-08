using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.LinkedList.RoundRobin
{
    class Program
    {
        static void Main()
        {
            RoundRobinScheduler scheduler = new RoundRobinScheduler();
            scheduler.AddProcess(1, 10, 1);
            scheduler.AddProcess(2, 5, 2);
            scheduler.AddProcess(3, 8, 1);
            int timeQuantum = 3;
            Console.WriteLine("Starting Round Robin Scheduling...");
            scheduler.SimulateScheduling(timeQuantum);
        }
    }

}
