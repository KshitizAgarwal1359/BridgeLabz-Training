using System;
class BankAccount
{
    public static string bankName = "dena bank"; //static variable shared by all
    public static int totalAccounts=0;
    public readonly string accountNumber; //readonly variable
    public string accountHolder; //instance variable
    public double balance;
    public BankAccount(string accountHolder,string accountNumber,double balance)
    {
        this.accountHolder= accountHolder;
        this.accountNumber=accountNumber;
        this.balance=balance;
        totalAccounts++; 
    }
    public static void GetTotalAccount() //static method
    {
        Console.WriteLine("Total accounts: "+totalAccounts);
    }
    public void DisplayAccount(object obj)
    {
        if(obj is BankAccount) //is operator for safe checking
        {
            Console.WriteLine("Bank Name: "+bankName);
            Console.WriteLine($"Account holder: "+accountHolder);
            Console.WriteLine($"Account Number: {accountNumber}");
            Console.WriteLine($"Balance: {balance}");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Invalid account obj.");
        }
    }
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance+=amount;
        }
    }
}
class BankSystem
{
    public static void Main(String[] args)
    {
        BankAccount account1 = new BankAccount("Kshitiz","DNB671",10000);
        BankAccount account2 = new BankAccount("Shashi","DNB9087",150000);
        account1.DisplayAccount(account1);
        account2.DisplayAccount(account2);
        BankAccount.GetTotalAccount();
    }
}