using System;
class BankAccount
{
    public int accountNumber; //public
    protected string accountHolder; //protected
    private double balance; //private
    public BankAccount(int an,string ah,double initialBalance)
    {
        accountNumber=an;
        accountHolder=ah;
        balance=initialBalance;
    }
    public double GetBalance()
    {
        return balance;
    }
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance+=amount;
        }
        else
        Console.WriteLine("Invalid amount.");
    }
    public void Withdraw(double amount)
    {
        if(amount>0 && amount<= balance)
        {
            balance-=amount;
        }
        else
        Console.WriteLine("Insufficient balance.");
    }   
}
class SavingsAccount : BankAccount
{
    public double interestRate;
    public SavingsAccount(int an,string ah,double initialBalance,double interest) : base(an, ah, initialBalance)
    {
        interestRate=interest;
    }
    public void Display()
    {
        Console.WriteLine("Account No." +accountNumber);
        Console.WriteLine("Account Holder: "+accountHolder);
        Console.WriteLine("balance: "+GetBalance());
        Console.WriteLine("Interest rate: "+interestRate+"\n");
    }
}
class Bank
{
    public static void Main(String[] args)
    {
        SavingsAccount account = new SavingsAccount(9087,"Kshitiz",15000,6.7); //calling constructor
        account.Display();
        account.Deposit(15000);
        Console.WriteLine("Balance after deposit: ₹" + account.GetBalance());
        account.Withdraw(10000);
        Console.WriteLine("Balance after withdraw: ₹" + account.GetBalance());
    }
}