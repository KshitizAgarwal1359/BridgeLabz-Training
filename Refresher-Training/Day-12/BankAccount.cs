using System;
class BankAccount
{
    private string accountNumber;
    private double balance;
    public BankAccount(string accountNumber,double balance)
    {
        this.accountNumber=accountNumber;
        this.balance=balance;
    }
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance+=amount;
        }
    }
    public void Withdraw(double amount)
    {
        if(amount<=0)
        return;
        if (balance < amount)
        {
            Console.WriteLine("Insufficient balance");
        }
        else
        balance-=amount;
        
    }
    public double GetBalance()
    {
        return balance;
    }
}
class Program
{
    static void Main(string[] args)
    {
        double initialBalance = double.Parse(Console.ReadLine());
        BankAccount account = new BankAccount("12345",initialBalance);
        int n = int.Parse(Console.ReadLine());
        for(int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            char operation = char.Parse(input[0]);
            double amount = double.Parse(input[1]);
            if (operation == 'D')
            {
                account.Deposit(amount);
            }
            else if (operation == 'W')
            {
                account.Withdraw(amount);
            }
        }
        Console.WriteLine(account.GetBalance());
    }
}