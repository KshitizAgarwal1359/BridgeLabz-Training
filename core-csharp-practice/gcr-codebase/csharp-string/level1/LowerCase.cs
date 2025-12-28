//Convert Text to Lowercase
using System;
class LowerCase
{
    public static void Main(String[] args)
    {
        string input = "Training";
        string upperCase=ConvertToLower(input);
        string builtInUpper=input.ToLower();
        Console.WriteLine("Lowercase: "+upperCase);
        Console.WriteLine("builtInLower: "+builtInUpper);
        Console.WriteLine("are both equal: "+upperCase.Equals(builtInUpper));
    }
    static string ConvertToLower(string str)
    {
        string result = "";
        foreach(char c in str)
        {
            if(c>='A' && c<='Z')
            result+=(char)(c+32);
            else
            result+=c;
        }
        return result;
    }
}