using System;
using System.Diagnostics;
class StringComparison
{
    static bool CompareStringCharAt(string s1,string s2)
    {
        if(s1.Length!=s2.Length)
        return false;
        for(int i = 0; i < s1.Length; i++)
        {
            if(s1[i]!=s2[i])
            return false;
        }
        return true;
    }
    public static void Main(String[] args)
    {
        Console.Write("Enetr 1st string: ");
        string s1=Console.ReadLine();
        Console.Write("Enter 2nd string: ");
        string s2=Console.ReadLine();
        bool charAtResult = CompareStringCharAt(s1,s2);  //custom comparison
        bool builtIn= string.Equals(s1,s2);
        Console.Write("\nComparison result: ");
        Console.Write("\n using charAt logic: "+charAtResult);
        Console.Write("\n using Equals: "+builtIn);
    }
}