//Find Substring Occurrences
using System;
class OccurrenceSubstring{
  public static void Main(){
    Console.WriteLine("Enter the string:");
    string str = Console.ReadLine();
    Console.WriteLine("Enter the substring:");
    string substr = Console.ReadLine();
    int count = 0;
    for (int i = 0; i <= str.Length - substr.Length; i++){
      if (str.Substring(i, substr.Length) == substr){
        count++;
      }
    }
    Console.WriteLine("No. of times : " + count);
  }
}