using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.LinkedList.TaskSchedular
{
    class Program
    {
        public static void Main(String[] args)
        {
            TaskCircularLinkedList scheduler = new TaskCircularLinkedList();
            scheduler.AddAtEnd(1, "Design Module", 1, new DateTime(2026, 1, 10));
            scheduler.AddAtEnd(2, "Code Review", 2, new DateTime(2026, 1, 12));
            scheduler.AddAtBeginning(3, "Client Meeting", 1, new DateTime(2026, 1, 8));
            scheduler.AddAtPosition(2, 4, "Testing", 3, new DateTime(2026, 1, 15));
            Console.WriteLine("\nAll Tasks:");
            scheduler.DisplayAllTasks();
            Console.WriteLine("\nView Next Tasks:");
            scheduler.ViewNextTask();
            scheduler.ViewNextTask();
            Console.WriteLine("\nSearch by Priority:");
            scheduler.SearchByPriority(1);
            Console.WriteLine("\nRemove Task:");
            scheduler.RemoveByTaskId(2);
            Console.WriteLine("\nFinal Task List:");
            scheduler.DisplayAllTasks();
        }
    }

}
