using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.Scenario_Based.LoanBuddy
{
    abstract class LoanApplication : IApprovable
    {
        protected Applicant applicant;
        protected int termInMonths;
        protected double interestRate;

        protected bool isApproved;

        // Constructor for loan setup
        public LoanApplication(Applicant applicant, int termInMonths, double interestRate)
        {
            this.applicant = applicant;
            this.termInMonths = termInMonths;
            this.interestRate = interestRate;
            this.isApproved = false;
        }

        // Approval logic hidden from outside
        protected bool CheckEligibility(int minCreditScore, double minIncome)
        {
            return applicant.GetCreditScore() >= minCreditScore &&
                   applicant.income >= minIncome;
        }

        public abstract bool ApproveLoan();
        public abstract double CalculateEmi();

        // Status readable but not modifiable outside
        public bool GetLoanStatus()
        {
            return isApproved;
        }
    }

}
