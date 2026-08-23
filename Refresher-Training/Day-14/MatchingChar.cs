using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main(string[] args)
    {
        string s = Console.ReadLine();
        string pattern = @"^[a-z][1-9][^a-z][^A-Z][A-Z].*$";
        if(Regex.IsMatch(s,pattern))
        Console.WriteLine("valid");
        else
        Console.WriteLine("not valid");
    }
}