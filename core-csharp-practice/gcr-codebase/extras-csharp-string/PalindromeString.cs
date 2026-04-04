//Palindrome String Check
using System;
class PalindromeString{
    public static void Main(String[] args){
        Console.Write("Enter the string: ");
        string str = Console.ReadLine();
        bool isPalindrome = IsPalindrome(str);
        if(isPalindrome)
            Console.WriteLine("the string is a palindrome");
        else
            Console.WriteLine("the string is not a palindrome");
        }
    //Method to check palindrome
    public static bool IsPalindrome(string str){
    str = str.ToLower();
    int start = 0;
    int end = str.Length - 1;
    while (start < end){
    if(str[start] != str[end]){
        return false;
    }
    start++;
    end--;
    }
    return true;
    }
}