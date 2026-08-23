using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main(string[] args)
    {
        string s = Console.ReadLine();
        string pattern = @"^\d{2,}[a-z]*[A-Z]*$";
        if(Regex.IsMatch(s,pattern))
        Console.WriteLine("valid");
        else
        Console.WriteLine("not valid");
    }
}