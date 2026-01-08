using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.LinkedList.TaskSchedular
{
    class TaskNode
    {
        public int taskId;
        public string taskName;
        public int priority;
        public DateTime dueDate;
        public TaskNode next;
        public TaskNode(int taskId, string taskName, int priority, DateTime dueDate) // Constructor to initialize task details
        {
            this.taskId = taskId;
            this.taskName = taskName;
            this.priority = priority;
            this.dueDate = dueDate;
            next = null;
        }
    }

}
