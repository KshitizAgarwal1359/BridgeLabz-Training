using System;
using System.Collections.Generic;
interface ILoanable
{
    void ApplyForLoan(double amount);
    double CalculateLoanEligibility();
}
abstract class BankAccount
{
    private string accountNumber;
    private string holderName;
    private double balance;
    public string AccountNumber
    {
        get{return accountNumber;}
        private set
        {
            if(string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("account number cannot be empty");
            accountNumber=value;
        }
    }
    public string HolderName
    {
        get{return holderName;}
        private set
        {
            if(string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Holder name cannot be empty.");
            holderName=value;
        }
    }
    public double Balance
    {
        get{return balance;}
        protected set
        {
            if(value<0)
            throw new ArgumentException("Balance cannot be negative");
            balance=value;
        }
    }
    protected BankAccount(string accountNumber,string holderName,double balance)
    {
        AccountNumber=accountNumber;
        HolderName=holderName;
        Balance=balance;
    }
    public abstract double CalculateInterest();
    public void Deposit(double amount)
    {
        if(amount <= 0)
        throw new ArgumentException("Deposit amount must be positive.");
        Balance+=amount;
    }
    public virtual void Withdraw(double amount)
    {
        if(amount<=0)
        throw new ArgumentException("Withdraw amount must be positive");
        if(amount>Balance) throw new InvalidOperationException("Insufficient balance");
        Balance-=amount;
    }
    public virtual void DisplayAccount()
    {
        Console.WriteLine($"Account no.: {AccountNumber}");
        Console.WriteLine($"Holder Name: {HolderName}");
        Console.WriteLine($"Balance: {Balance}");
    }
}
class SavingsAccount : BankAccount, ILoanable
{
    public SavingsAccount(string accNo, string name, double balance)
        : base(accNo, name, balance) { }

    public override double CalculateInterest()
    {
        return Balance * 0.04; // 4% interest
    }

    public void ApplyForLoan(double amount)
    {
        Console.WriteLine($"Loan application submitted for ₹{amount}");
    }

    public double CalculateLoanEligibility()
    {
        return Balance * 5; // Eligible up to 5x balance
    }
}
class CurrentAccount : BankAccount, ILoanable
{
    public CurrentAccount(string accNo, string name, double balance)
        : base(accNo, name, balance) { }

    public override double CalculateInterest()
    {
        return Balance * 0.01; // 1% interest
    }

    // Overdraft allowed
    public override void Withdraw(double amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Withdraw amount must be positive");

        Balance -= amount;
    }

    public void ApplyForLoan(double amount)
    {
        Console.WriteLine($"Business loan applied for ₹{amount}");
    }

    public double CalculateLoanEligibility()
    {
        return Balance * 10; // Higher eligibility
    }
}
class BankingSystem
{
    public static void Main(String[] args)
    {
        List<BankAccount> accounts = new List<BankAccount>
        {
            new SavingsAccount("SB101", "Kshitiz", 50000),
            new CurrentAccount("CA202", "Shashi", 100000)
        };

        foreach (BankAccount account in accounts)
        {
            account.DisplayAccount();

            double interest = account.CalculateInterest();
            Console.WriteLine($"Calculated Interest: {interest}");

            if (account is ILoanable loanAccount)
            {
                Console.WriteLine($"Loan Eligibility: {loanAccount.CalculateLoanEligibility()}");
            }

            Console.WriteLine("----------------------------------");
        }
    }
}
