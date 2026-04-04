using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.Scenario_Based.LoanBuddy
{
    using System;

    class LoanBuddyMenu
    {
        public static void Start()
        {
            int choice;

            do
            {
                Console.WriteLine("\n--- LoanBuddy : Loan Approval Automation ---");
                Console.WriteLine("1. Apply Home Loan");
                Console.WriteLine("2. Apply Auto Loan");
                Console.WriteLine("3. Exit");
                Console.Write("Enter choice: ");

                choice = int.Parse(Console.ReadLine());

                if (choice == 1 || choice == 2)
                {
                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter Credit Score: ");
                    int creditScore = int.Parse(Console.ReadLine());

                    Console.Write("Enter Monthly Income: ");
                    double income = double.Parse(Console.ReadLine());

                    Console.Write("Enter Loan Amount: ");
                    double loanAmount = double.Parse(Console.ReadLine());

                    Applicant applicant = new Applicant(
                        name, creditScore, income, loanAmount
                    );

                    LoanApplication loan;

                    if (choice == 1)
                    {
                        loan = new HomeLoan(applicant);
                    }
                    else
                    {
                        loan = new AutoLoan(applicant);
                    }

                    LoanProcessor.ProcessLoan(loan);
                }

            } while (choice != 3);
        }
    }

}
