using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.Scenario_Based.ExamProctor
{
   public class ExamProctorImpl : IExamProctor
    {
        private CustomStack navigationStack;
        private CustomHashMap answerMap;
        public ExamProctorImpl()
        {
            navigationStack = new CustomStack();
            answerMap = new CustomHashMap();
        }
        public void VisitQuestion(int questionId) //track question navigation
        {
            navigationStack.Push(questionId);
            Console.WriteLine($"Visited question {questionId}");
        }
        public void SubmitAnswer(int questionId,string answer) //store answer
        {
            answerMap.Put(questionId, answer);
            Console.WriteLine($"Answer saved for Question {questionId}");
        }
        public void ReviewLastQuestion() //review last visited question
        {
            int lastQuestion = navigationStack.Pop();
            if (lastQuestion != -1)
            {
                Console.WriteLine($"Reviewing question: {lastQuestion}");
            }
        }
        public void SubmitExam() //submit exam and calculate score
        {
            int score = CalculateScore();
            Console.WriteLine($"Exam submitted final score : {score}");
        }
        private int CalculateScore() //scoring logic function
        {
            int score = 0;
            string[] correctAnswers = { "", "A", "B", "C", "D", "A" };
            MapNode[] bukects = answerMap.GetBuckets();
            for(int i = 0; i < bukects.Length; i++)
            {
                MapNode current = bukects[i];
                while (current != null)
                {
                    if(current.key<correctAnswers.Length && current.value.Equals(correctAnswers[current.key]))
                    {
                        score++;
                    }
                    current = current.next;
                }
            }
            return score;
        }
    }
}
