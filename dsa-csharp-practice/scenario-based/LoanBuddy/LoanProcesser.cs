using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.Scenario_Based.LoanBuddy
{
    using System;

    class LoanProcessor
    {
        public static void ProcessLoan(LoanApplication loan)
        {
            if (loan.ApproveLoan())
            {
                Console.WriteLine("Loan Approved!");
                Console.WriteLine("Monthly EMI: " + loan.CalculateEmi());
            }
            else
            {
                Console.WriteLine("Loan Rejected due to eligibility criteria.");
            }
        }
    }

}
