using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.Scenario_Based.ExamProctor
{
    class ExamProctorMain
    {
        public static void Main(string[] args)
        {
            IExamProctor exam = new ExamProctorImpl();
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Exam Proctor Menu");
                Console.WriteLine("1. Visit Question");
                Console.WriteLine("2. Submit answer");
                Console.WriteLine("3. Review Last Question");
                Console.WriteLine("4. Submit Exam");
                Console.WriteLine("5. Exit");
                Console.Write("Enter choice: ");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.Write("Enter Question ID: ");
                        int qId = int.Parse(Console.ReadLine());
                        exam.VisitQuestion(qId);
                        break;
                    case "2":
                        Console.Write("Enter Question ID: ");
                        int aId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Answer: ");
                        string answer = Console.ReadLine();
                        exam.SubmitAnswer(aId, answer);
                        break;
                    case "3":
                        exam.ReviewLastQuestion();
                        break;
                    case "4":
                        exam.SubmitExam();
                        isRunning = false;
                        break;
                    case "5":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        return;
                }
            }
        }
    }
}
