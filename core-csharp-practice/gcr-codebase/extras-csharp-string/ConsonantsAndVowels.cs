//Count Vowels and Consonants
using System;
class ConsonantsAndVowels{
    public static void Main(string[] args){
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();
        int vowels = 0;
        int consonants = 0;
        str = str.ToUpper();
        foreach (char ch in str){ //finding vowels and consonants
        if (ch >= 'A' && ch <= 'Z'){
        if (ch == 'A' || ch == 'E' || ch == 'I' ||ch == 'O' || ch == 'U'){
            vowels++;
        }
        else{
            consonants++;
        }
        }
    }
    Console.WriteLine("Vowels: " + vowels);
    Console.WriteLine("Consonants: " + consonants);
    }
}