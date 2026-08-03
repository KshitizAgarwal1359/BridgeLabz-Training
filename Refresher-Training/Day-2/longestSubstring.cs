/*2. Longest Substring Without Repeating Characters

Problem Statement
Given a string, find the length of the longest substring without repeating characters.
Example
Input
"abcabcbb"
Output
3
Explanation
"abc"
Input
"bbbbb"
Output
1*/

using System;
using System.Text;
class Program
{
    public static void Main(string[] args){
    string str = Console.ReadLine();
    int n = str.Length;
    int max = 0;
    for(int i=0;i<n;i++){
        string curr = "";
        for(int j = i; j < n; j++)
            {
                
                if(curr.Contains(str[j]))
                break;
                curr = curr+str[j];
                if (curr.Length > max)
                {
                    max=curr.Length;
                }
            }
    }
    Console.WriteLine($"{max}");
}
}