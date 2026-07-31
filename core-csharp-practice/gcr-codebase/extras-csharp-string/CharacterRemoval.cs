//Remove a Specific Character from a String
using System;
class CharacterRemoval{
    public static void Main(string[] args){
    Console.Write("Enter a string: ");
    string str = Console.ReadLine();
    Console.Write("Enter the char: ");
    char ch = Console.ReadKey().KeyChar;
    Console.WriteLine();
    string ans = "";
    //loop for adding
    for (int i = 0; i < str.Length; i++){
    if (str[i] != ch){
        ans += str[i];
    }
    } 
    Console.WriteLine("After removal : " + ans);
    }
}