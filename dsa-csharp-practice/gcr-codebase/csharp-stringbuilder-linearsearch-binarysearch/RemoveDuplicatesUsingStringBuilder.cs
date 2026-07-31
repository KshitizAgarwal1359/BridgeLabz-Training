using System;
using System.Text;
using System.Collections.Generic;

class RemoveDuplicatesUsingStringBuilder
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        // Tracks characters already added
        HashSet<char> seenCharacters = new HashSet<char>();

        // Initialize StringBuilder with known capacity
        StringBuilder result = new StringBuilder(input.Length);

        foreach (char ch in input)
        {
            // Add only if character is not already present
            if (seenCharacters.Add(ch))
            {
                result.Append(ch);
            }
        }

        Console.WriteLine("String after removing duplicates: " + result.ToString());
    }
}
