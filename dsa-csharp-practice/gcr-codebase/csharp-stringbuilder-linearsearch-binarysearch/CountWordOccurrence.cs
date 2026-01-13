using System;
using System.IO;

class CountWordOccurrence
{
    static void Main()
    {
        string filePath = "sample.txt"; // Ensure file exists
        Console.Write("Enter the word to search: ");
        string searchWord = Console.ReadLine();
        int count = 0;
        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Split line into words
                    string[] words = line.Split(
                        new char[] { ' ', ',', '.', '!', '?', ';', ':', '-', '\t' },
                        StringSplitOptions.RemoveEmptyEntries);
                    foreach (string word in words)
                    {
                        if (word.Equals(searchWord, StringComparison.OrdinalIgnoreCase))
                        {
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine($"The word \"{searchWord}\" appears {count} times.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Error: File not found.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("I/O Error: " + ex.Message);
        }
    }
}
