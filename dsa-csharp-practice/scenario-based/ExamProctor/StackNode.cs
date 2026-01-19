using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BridgeLabzDSA.Scenario_Based.ExamProctor
{
    public class StackNode
    {
        public int questionId;
        public StackNode next;
        public StackNode(int questionId)
        {
            this.questionId = questionId;
            next = null;
        }
    }
    public class CustomStack //lifo
    {
        private StackNode top;
        public void Push(int questionId) //push question into stack
        {
            StackNode newNode = new StackNode(questionId);
            newNode.next = top;
            top = newNode;
        }
        public int Pop() //pop last visited question
        {
            if (top == null)
            {
                Console.WriteLine("No questions");
                return -1;
            }
            int value = top.questionId;
            top = top.next;
            return value;
        }
        public bool IsEmpty() ///check if stack is empty
        {
            return top == null;
        }
    }
}
