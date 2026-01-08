using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.LinkedList.RoundRobin
{
    class RoundRobinScheduler
    {
        private ProcessNode head;
        private ProcessNode tail;
        public void AddProcess(int processId, int burstTime, int priority) // Add process at end of circular list
        {
            ProcessNode newNode = new ProcessNode(processId, burstTime, priority);

            if (head == null)
            {
                head = tail = newNode;
                newNode.next = head;
                return;
            }

            tail.next = newNode;
            newNode.next = head;
            tail = newNode;
        }
        private void RemoveProcess(int processId) // Remove process by Process ID
        {
            if (head == null)
                return;

            ProcessNode current = head;
            ProcessNode prev = tail;

            do
            {
                if (current.processId == processId)
                {
                    if (current == head)
                        head = head.next;

                    if (current == tail)
                        tail = prev;

                    prev.next = current.next;
                    return;
                }

                prev = current;
                current = current.next;

            } while (current != head);
        }
        public void SimulateScheduling(int timeQuantum)  // Simulate Round Robin Scheduling
        {
            if (head == null)
            {
                Console.WriteLine("No processes to schedule.");
                return;
            }

            int currentTime = 0;
            int completedProcesses = 0;
            int totalProcesses = CountProcesses();

            ProcessNode current = head;

            while (completedProcesses < totalProcesses)
            {
                if (current.remainingTime > 0)
                {
                    int executionTime = Math.Min(timeQuantum, current.remainingTime);
                    current.remainingTime -= executionTime;
                    currentTime += executionTime;

                    
                    UpdateWaitingTime(current, executionTime); // Update waiting time for other processes

                    if (current.remainingTime == 0)
                    {
                        current.turnaroundTime = currentTime;
                        completedProcesses++;
                        RemoveProcess(current.processId);
                    }

                    DisplayProcesses();
                }

                current = current.next;
            }

            CalculateAverages(totalProcesses);
        }

       
        private void UpdateWaitingTime(ProcessNode runningProcess, int time)  // Update waiting time for all other processes
        {
            ProcessNode temp = head;

            if (temp == null)
                return;

            do
            {
                if (temp != runningProcess && temp.remainingTime > 0)
                    temp.waitingTime += time;

                temp = temp.next;
            } while (temp != head);
        }
        public void DisplayProcesses() // Display all processes in circular queue
        {
            if (head == null)
            {
                Console.WriteLine("No active processes.");
                return;
            }

            Console.WriteLine("\nCurrent Process Queue:");
            ProcessNode temp = head;

            do
            {
                Console.WriteLine(
                    $"PID: {temp.processId}, Remaining: {temp.remainingTime}, Priority: {temp.priority}"
                );
                temp = temp.next;
            } while (temp != head);
        }
        private int CountProcesses()  // Count total processes
        {
            if (head == null)
                return 0;

            int count = 0;
            ProcessNode temp = head;

            do
            {
                count++;
                temp = temp.next;
            } while (temp != head);

            return count;
        }
        private void CalculateAverages(int totalProcesses)// Calculate and display average times
        { 
            double totalWaitingTime = 0;
            double totalTurnaroundTime = 0;
            ProcessNode temp = head;
            if (temp == null)
            {
                Console.WriteLine("\nScheduling completed.");
                return;
            }
            do
            {
                totalWaitingTime += temp.waitingTime;
                totalTurnaroundTime += temp.turnaroundTime;
                temp = temp.next;
            } while (temp != head);
            Console.WriteLine("\nScheduling Completed.");
            Console.WriteLine($"Average Waiting Time: {totalWaitingTime / totalProcesses}");
            Console.WriteLine($"Average Turnaround Time: {totalTurnaroundTime / totalProcesses}");
        }
    }
}
