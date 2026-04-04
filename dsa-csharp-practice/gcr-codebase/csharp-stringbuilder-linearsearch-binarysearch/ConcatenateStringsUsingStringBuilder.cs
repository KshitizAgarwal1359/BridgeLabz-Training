using System;
using System.Text;

class ConcatenateStringsUsingStringBuilder
{
    static void Main()
    {
        string[] words = { "Hello", " ", "World", "!", " Welcome", " to", " C#" };
        // Calculate total length to set initial capacity
        int totalLength = 0;
        foreach (string word in words)
        {
            totalLength += word.Length;
        }
        // Initialize StringBuilder with known capacity
        StringBuilder result = new StringBuilder(totalLength);
        // Append each string efficiently
        foreach (string word in words)
        {
            result.Append(word);
        }
        Console.WriteLine("Concatenated String:");
        Console.WriteLine(result.ToString());
    }
}
