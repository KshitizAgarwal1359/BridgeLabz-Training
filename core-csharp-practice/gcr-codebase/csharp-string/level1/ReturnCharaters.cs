using System;
class ReturnCharacters
{
    public static char[] GetCharatersManually(string str)
    {
        char[] chars=new char[str.Length];
        for(int i = 0; i < str.Length; i++)
        {
            chars[i]=str[i];
        }
        return chars;
    }
    public static void Main(String[] args)
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        char[] manualChars=GetCharatersManually(input);
        char[] builtInChars=input.ToCharArray();
        Console.WriteLine("Characters using manual method: ");
        foreach(char c in manualChars)
        {
            Console.Write(c+" ");
        }
        Console.WriteLine("\nCharacters using TOCHarArray: ");
        foreach(char c in builtInChars)
        {
            Console.Write(c +" ");
        }
    }
}