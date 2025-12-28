//Write a replace method in C# that replaces a given word with another word in a sentence:
using System;
class WordReplacement{
    public static void Main(string[] args){
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();
        Console.Write("Enter the word to replace: ");
        string previousWord = Console.ReadLine();
        Console.Write("Enter the new word: ");
        string newWord = Console.ReadLine();
        string ans = sentence.Replace(previousWord, newWord);
        Console.WriteLine("after replacement : " + ans);
}
}