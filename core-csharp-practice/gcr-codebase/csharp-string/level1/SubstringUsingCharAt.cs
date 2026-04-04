using System;
class SubstringUsingCharAt
{
    public static string CreateSubStrCharAt(string str,int start,int end)
    {
        string result="";
        for(int i = start; i < end; i++)
        {
            result+=str[i];
        }
        return result;
    }
    public static void Main(String[] args)
    {
        Console.Write("ENter a string: ");
        string input=Console.ReadLine();
        Console.Write("Enter start index: ");
        int startIndex=int.Parse(Console.ReadLine());
        Console.Write("Enter the end index: ");
        int endIndex=int.Parse(Console.ReadLine());
        string charAtSubstring=CreateSubStrCharAt(input,startIndex,endIndex);
        string builtSubstring=input.Substring(startIndex,endIndex-startIndex);
        Console.WriteLine("Substring results: ");
        Console.WriteLine("using charAt logic: "+charAtSubstring);
        Console.WriteLine("Using substring(): "+builtSubstring);
    }
}