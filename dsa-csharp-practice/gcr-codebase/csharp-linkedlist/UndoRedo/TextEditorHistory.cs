using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.LinkedList.UndoRedo
{
    class TextEditorHistory
    {
        private TextStateNode head;
        private TextStateNode tail;
        private TextStateNode current;
        private int maxSize;
        private int size;

       
        public TextEditorHistory(int maxSize)  // Initialize history with fixed size
        {
            this.maxSize = maxSize;
            size = 0;
        }

        
        public void AddState(string content) // Add new text state
        {
            TextStateNode newNode = new TextStateNode(content);

            
            if (current != null && current.next != null)// Remove redo history if new action is performed
            {
                current.next.prev = null;
                current.next = null;
                tail = current;
            }

            if (head == null)
            {
                head = tail = current = newNode;
                size++;
                return;
            }

            tail.next = newNode;
            newNode.prev = tail;
            tail = newNode;
            current = newNode;
            size++;

            
            if (size > maxSize) // Remove oldest state if limit exceeded
            {
                head = head.next;
                head.prev = null;
                size--;
            }
        }

        
        public void Undo() // Undo operation
        {
            if (current == null || current.prev == null)
            {
                Console.WriteLine("Nothing to undo.");
                return;
            }

            current = current.prev;
            DisplayCurrentState();
        }

       
        public void Redo()  // Redo operation
        { 
            if (current == null || current.next == null)
            {
                Console.WriteLine("Nothing to redo.");
                return;
            }

            current = current.next;
            DisplayCurrentState();
        }

        
        public void DisplayCurrentState() // Display current text state
        {
            if (current == null)
            {
                Console.WriteLine("Editor is empty.");
                return;
            }

            Console.WriteLine($"Current Text: \"{current.content}\"");
        }
    }
}
