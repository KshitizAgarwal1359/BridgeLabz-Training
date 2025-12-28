//Compare Two Strings lexicographically
using System;
class CompareStrings{
    public static void Main(string[] args){
    Console.WriteLine("Enter string: ");
    string s1 = Console.ReadLine();
    Console.WriteLine("Enter string: ");
    string s2 = Console.ReadLine();
    int minimum = Math.Min(s1.Length, s2.Length);
    int ans = 0;
    //Compare character by character
    for (int i = 0; i < minimum; i++){
    if(s1[i] != s2[i]){
        ans = s1[i] - s2[i];
        break;
    }
    }
    // If all characters matched but lengths differ
    if (ans == 0 && s1.Length != s2.Length){
    ans = s1.Length - s2.Length;
    }
    if (ans == 0){
    Console.WriteLine($"\"{s1}\" and \"{s2}\" are equal in lexicographical order");
    }else if (ans < 0){
    Console.WriteLine($"\"{s1}\" comes before \"{s2}\" in lexicographical order");
    }else{
    Console.WriteLine($"\"{s1}\" comes after \"{s2}\" in lexicographical order");
    }
}
}