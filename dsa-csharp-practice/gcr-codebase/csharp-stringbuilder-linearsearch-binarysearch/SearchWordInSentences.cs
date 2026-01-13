using System;

class SearchWordInSentences
{
    static void Main()
    {
        string[] sentences =
        {
            "C# is a powerful programming language",
            "Linear search is easy to understand",
            "Data structures are important",
            "Searching algorithms are fundamental"
        };
        Console.Write("Enter word to search: ");
        string searchWord = Console.ReadLine();
        bool found = false;
        // Linear Search through sentences
        for (int i = 0; i < sentences.Length; i++)
        {
            // Case-insensitive search
            if (sentences[i].IndexOf(searchWord, StringComparison.OrdinalIgnoreCase) >= 0)
            {
                Console.WriteLine("First sentence containing the word:");
                Console.WriteLine(sentences[i]);
                found = true;
                break;
            }
        }
        if (!found)
        {
            Console.WriteLine("No sentence contains the given word.");
        }
    }
}
