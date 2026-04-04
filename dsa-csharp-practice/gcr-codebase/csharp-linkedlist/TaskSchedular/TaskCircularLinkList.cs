using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.LinkedList.TaskSchedular
{
    class TaskCircularLinkedList
    {
        private TaskNode head;
        private TaskNode current;
        public void AddAtBeginning(int taskId, string taskName, int priority, DateTime dueDate) // Add task at beginning
        {
            TaskNode newNode = new TaskNode(taskId, taskName, priority, dueDate);
            if (head == null)
            {
                head = newNode;
                newNode.next = head;
                current = head;
                return;
            }
            TaskNode temp = head;
            while (temp.next != head)
                temp = temp.next;

            newNode.next = head;
            temp.next = newNode;
            head = newNode;
        }
        public void AddAtEnd(int taskId, string taskName, int priority, DateTime dueDate) // Add task at end
        {
            TaskNode newNode = new TaskNode(taskId, taskName, priority, dueDate);
            if (head == null)
            {
                head = newNode;
                newNode.next = head;
                current = head;
                return;
            }
            TaskNode temp = head;
            while (temp.next != head)
                temp = temp.next;

            temp.next = newNode;
            newNode.next = head;
        }
        public void AddAtPosition(int position, int taskId, string taskName, int priority, DateTime dueDate) // Add task at specific position (1-based index)
        {
            if (position <= 0)
            {
                Console.WriteLine("Invalid position.");
                return;
            }
            if (position == 1)
            {
                AddAtBeginning(taskId, taskName, priority, dueDate);
                return;
            }
            TaskNode temp = head;
            for (int i = 1; i < position - 1 && temp.next != head; i++)
                temp = temp.next;
            TaskNode newNode = new TaskNode(taskId, taskName, priority, dueDate);
            newNode.next = temp.next;
            temp.next = newNode;
        }
        public void RemoveByTaskId(int taskId) // Remove task by Task ID
        {
            if (head == null)
            {
                Console.WriteLine("Task list is empty.");
                return;
            }
            TaskNode temp = head;
            TaskNode prev = null;
            do
            {
                if (temp.taskId == taskId)
                {
                    if (prev == null)
                    {
                        TaskNode last = head;
                        while (last.next != head)
                            last = last.next;

                        head = head.next;
                        last.next = head;
                    }
                    else
                    {
                        prev.next = temp.next;
                    }
                    Console.WriteLine("Task removed successfully.");
                    return;
                }
                prev = temp;
                temp = temp.next;
            } while (temp != head);
            Console.WriteLine("Task not found.");
        }
        public void ViewNextTask() // View current task and move to next
        {
            if (current == null)
            {
                Console.WriteLine("No tasks available.");
                return;
            }
            DisplayTask(current);
            current = current.next;
        }
        public void DisplayAllTasks() // Display all tasks starting from head
        {
            if (head == null)
            {
                Console.WriteLine("No tasks to display.");
                return;
            }
            TaskNode temp = head;
            do
            {
                DisplayTask(temp);
                temp = temp.next;
            } while (temp != head);
        }
        public void SearchByPriority(int priority) // Search tasks by priority
        {
            if (head == null)
            {
                Console.WriteLine("Task list is empty.");
                return;
            }
            TaskNode temp = head;
            bool found = false;
            do
            {
                if (temp.priority == priority)
                {
                    DisplayTask(temp);
                    found = true;
                }
                temp = temp.next;
            } while (temp != head);

            if (!found)
                Console.WriteLine("No tasks found with given priority.");
        }
        private void DisplayTask(TaskNode task) // Display a single task
        {
            Console.WriteLine(
                $"ID: {task.taskId}, Name: {task.taskName}, Priority: {task.priority}, Due: {task.dueDate.ToShortDateString()}"
            );
        }
    }
}
