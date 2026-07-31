using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.Scenario_Based.LoanBuddy
{
    class AutoLoan : LoanApplication
    {
        public AutoLoan(Applicant applicant)
            : base(applicant, 60, 0.10) // 5 years, 10% interest
        {
        }

        public override bool ApproveLoan()
        {
            // Auto loans have relaxed rules
            isApproved = CheckEligibility(650, 25000);
            return isApproved;
        }

        public override double CalculateEmi()
        {
            double monthlyRate = interestRate / 12;
            double numerator = applicant.loanAmount * monthlyRate *
                               Math.Pow(1 + monthlyRate, termInMonths);
            double denominator = Math.Pow(1 + monthlyRate, termInMonths) - 1;

            return numerator / denominator;
        }
    }

}
