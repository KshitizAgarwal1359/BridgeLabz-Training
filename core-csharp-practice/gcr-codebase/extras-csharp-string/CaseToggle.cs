//Toggle Case of Characters
using System;
class CaseToggle{
    public static void Main(string [] args){
        Console.WriteLine("Enter the string:");
        string str = Console.ReadLine();
        string ans = "";
    for (int i = 0; i < str.Length; i++){     //toggling
    char ch = str[i];
    if (char.IsUpper(ch)){
        ans += char.ToLower(ch);
    }
    else if (char.IsLower(ch)){
        ans += char.ToUpper(ch);
    }
    else{
        ans += ch; 
    }
    }
    Console.WriteLine("Toggled string is: " + ans);
}
}