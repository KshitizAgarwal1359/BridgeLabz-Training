//Reverse a String
using System;
class StringReversal{
    public static void Main(string[] args){
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();
        string reversed = ReverseString(str);
        Console.WriteLine("Original String: " + str);
        Console.WriteLine("Reversed String: " + reversed);
    }
    public static string ReverseString(string str){   //method to reverse string
    string ans = "";
    for (int i = str.Length - 1; i >= 0; i--){
        ans += str[i]; 
    }
    return ans;
    }
}