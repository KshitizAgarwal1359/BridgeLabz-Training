using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.LinkedList.RoundRobin
{
    class ProcessNode
    {
        public int processId;
        public int burstTime;
        public int remainingTime;
        public int priority;
        public int waitingTime;
        public int turnaroundTime;
        public ProcessNode next;
        public ProcessNode(int processId, int burstTime, int priority)   // Constructor to initialize process details
        {
            this.processId = processId;
            this.burstTime = burstTime;
            this.remainingTime = burstTime;
            this.priority = priority;
            waitingTime = 0;
            turnaroundTime = 0;
            next = null;
        }
    }

}
