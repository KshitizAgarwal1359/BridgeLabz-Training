using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main(string[] args)
    {
        string s = Console.ReadLine();
        string pattern = @"^[a-zA-Z]*s$";
        if(Regex.IsMatch(s,pattern))
        Console.WriteLine("valid");
        else
        Console.WriteLine("not valid");
    }
}