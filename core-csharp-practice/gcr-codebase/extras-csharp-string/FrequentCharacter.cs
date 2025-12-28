//Find the Most Frequent Character
using System;
class FrequentCharacter{
    public static void Main(string[] args){
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();
        int[] freq = new int[256];
        foreach (char ch in str)
            freq[ch]++;
            char mostFrequent = str[0];
    //looping to find out
    for (int i = 1; i < str.Length; i++){
        if (freq[str[i]] > freq[mostFrequent]){
        mostFrequent = str[i];
        }
    }
    Console.WriteLine("Most Frequent Character:" + mostFrequent);
}
}