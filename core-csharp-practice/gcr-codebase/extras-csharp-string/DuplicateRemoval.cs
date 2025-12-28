//Remove Duplicates from a String
using System;
class DuplicateRemoval{
    public static void Main(string[] args){
        Console.Write("Enter the string: ");
        string str = Console.ReadLine();
        string ans = "";
        for(int i = 0; i < str.Length; i++){
        char ch = str[i];
        bool present = false;
      // checking if character already exists 
        for (int j = 0; j < ans.Length; j++){
        if (ans[j] == ch){
        present = true;
        break;
        }
    }
    if (!present){
        ans += ch;
    }
    }
    Console.WriteLine("after removal : " + ans);
}
}