using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.Scenario_Based.LoanBuddy
{
    class HomeLoan : LoanApplication
    {
        public HomeLoan(Applicant applicant)
            : base(applicant, 240, 0.08) // 20 years, 8% interest
        {
        }

        public override bool ApproveLoan()
        {
            // Home loans have stricter rules
            isApproved = CheckEligibility(700, 40000);
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
