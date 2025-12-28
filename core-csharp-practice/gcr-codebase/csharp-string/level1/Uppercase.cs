// Convert Text to Uppercase
using System;
class UpperCase
{
    public static void Main(String[] args)
    {
        string input = "Training";
        string upperCase=ConvertToUpper(input);
        string builtInUpper=input.ToUpper();
        Console.WriteLine("uppercase: "+upperCase);
        Console.WriteLine("builtInUpper: "+builtInUpper);
        Console.WriteLine("are both equal: "+upperCase.Equals(builtInUpper));
    }
    static string ConvertToUpper(string str)
    {
        string result = "";
        foreach(char c in str)
        {
            if(c>='a' && c<='z')
            result+=(char)(c-32);
            else
            result+=c;
        }
        return result;
    }
}