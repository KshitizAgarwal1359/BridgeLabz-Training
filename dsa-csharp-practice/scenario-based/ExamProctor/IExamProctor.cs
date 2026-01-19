using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.Scenario_Based.ExamProctor
{
    interface IExamProctor
    {
        void VisitQuestion(int questionId);
        void SubmitAnswer(int questionId, string answer);
        void ReviewLastQuestion();
        void SubmitExam();
    }
}
