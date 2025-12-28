//Split Text into Words and Display Word Length.
using System;
class TextToWords
{
    public static void Main(String[] args){
    string input = "This is part of My Training";
    Console.WriteLine("Word\tLength");
    SplitAndDisplay(input);
    }
  //Method to split text and display word lengths
    public static void SplitAndDisplay(string str){
    string word = "";
    for (int i = 0; i < str.Length; i++){
    char c = str[i];
    if (c != ' '){
        word += c; // build current word
    }
    else if (word != ""){
        Console.WriteLine(word + "\t" + GetLength(word));
        word = ""; 
    }
    }
    //Print the last word
    if (word != ""){
    Console.WriteLine(word + "\t" + GetLength(word));
    }
}
    //Method to calculate string length 
    public static int GetLength(string str){
    int count = 0;
    foreach (char c in str){
    count++;
    }
    return count;
    }
}