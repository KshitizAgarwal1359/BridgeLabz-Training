using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.Scenario_Based.LoanBuddy
{
    class Applicant
    {
        public string name;
        public double income;
        public double loanAmount;

        private int creditScore;

        public Applicant(string name, int creditScore, double income, double loanAmount)
        {
            this.name = name;
            this.creditScore = creditScore;
            this.income = income;
            this.loanAmount = loanAmount;
        }

        // Credit score is exposed safely
        public int GetCreditScore()
        {
            return creditScore;
        }
    }

}
