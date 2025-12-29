//Palindrome
using System;
class Palindrome
{
    public static void Main(string[] args){
    string input = GetInput();
    bool isPalindrome = CheckPalindrome(input);
    displayAns(input, isPalindrome);
}
    public static string GetInput(){ //Function to get user input
    Console.Write("Enter the word or phrase: ");
    return Console.ReadLine().ToLower().Replace(" ", "");
    }
    public static bool CheckPalindrome(string str){ // Function to check if the string is a palindrome
    int left = 0;
    int right = str.Length - 1;
    while (left < right){
    if (str[left] != str[right]){
    return false;
    }
    left++;
    right--;
}
    return true;
}
    public static void displayAns(string old, bool isPalindrome){ // Function to display the result
    if (isPalindrome){
    Console.WriteLine($"'{old}' is a palindrome.");
    }else{
    Console.WriteLine($"'{old}' is not a palindrome.");
    }
}
}