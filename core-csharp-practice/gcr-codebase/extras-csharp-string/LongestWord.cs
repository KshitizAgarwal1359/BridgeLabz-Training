//Find the Longest Word in a Sentence
using System;
class LongestWord{
public static void Main(string[] args){
    Console.Write("Enter the sentence: ");
    string sentence = Console.ReadLine();
    string longest = FindLongestWord(sentence);
    Console.WriteLine("Longest Word: " + longest);
}
public static string FindLongestWord(string str){ //method to find longest word
    string current = "";
    string longest = "";
    for (int i = 0; i < str.Length; i++){
    char ch = str[i];
    if (ch != ' '){
        current += ch;
    }
    else{
        if (current.Length > longest.Length)
        longest = current;
        current = "";
        }
    }
    if (current.Length > longest.Length){
    longest = current;
    }
    return longest;
}
}