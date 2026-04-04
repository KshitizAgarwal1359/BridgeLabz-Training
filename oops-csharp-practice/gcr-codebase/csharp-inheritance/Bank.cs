using System;
class BankAccount{
    public string accountNumber;
    public double balance;
    public BankAccount(string AccountNumber, double Balance){
    accountNumber = AccountNumber;
    balance = Balance;
    }
    public void DisplayCommonDetails(){
    Console.WriteLine("Account Number: " + accountNumber);
    Console.WriteLine("Balance: " + balance);
    }
}
class SavingsAccount : BankAccount{
    public double interestRate;
    public SavingsAccount(string AccountNumber, double Balance, double InterestRate): base(AccountNumber, Balance){
    interestRate = InterestRate;
    }
    public void DisplayAccountType()
    {
        Console.WriteLine("\nAccount Type: Savings Account");
        DisplayCommonDetails();
        Console.WriteLine("Interest Rate: " + interestRate + "%");
    }
}
class CheckingAccount : BankAccount
{
    public double withdrawalLimit;

    public CheckingAccount(string AccountNumber, double Balance, double WithdrawalLimit)
        : base(AccountNumber, Balance)
    {
        withdrawalLimit = WithdrawalLimit;
    }

    public void DisplayAccountType()
    {
        Console.WriteLine("\nAccount Type: Checking Account");
        DisplayCommonDetails();
        Console.WriteLine("Withdrawal Limit: " + withdrawalLimit);
    }
}
class FixedDepositAccount : BankAccount
{
    public int periodMonths;

    public FixedDepositAccount(string AccountNumber, double Balance, int Period)
        : base(AccountNumber, Balance)
    {
        periodMonths = Period;
    }
    public void DisplayAccountType()
    {
        Console.WriteLine("\nAccount Type: Fixed Deposit Account");
        DisplayCommonDetails();
        Console.WriteLine("Lock-in Period: " + periodMonths + " months");
    }
}
class Bank{
    static void Main(){
        SavingsAccount savingAccounts = new SavingsAccount("AKShat 1", 25000, 6.5);
        CheckingAccount checkingAccounts = new CheckingAccount("Shrivastav1", 18000, 5000);
        FixedDepositAccount fixedDepositAccount = new FixedDepositAccount("FD1", 100000, 24);
        savingAccounts.DisplayAccountType();
        checkingAccounts.DisplayAccountType();
        fixedDepositAccount.DisplayAccountType();
        
    }
}