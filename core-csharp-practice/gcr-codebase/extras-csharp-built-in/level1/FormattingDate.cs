//Problem 3: Date Formatting
// Hint: Use DateTime.ToString() with custom date format strings.
using System;
class DateFormatting{
    public static void Main(string[] args){
    DateTime today = DateTime.Now; // Get current date
    Console.WriteLine("1 (dd/MM/yyyy): " + today.ToString("dd/MM/yyyy"));//1: dd/MM/yyyy
    Console.WriteLine("2 (yyyy-MM-dd): " + today.ToString("yyyy-MM-dd")); //2: yyyy-MM-dd
    Console.WriteLine("3 (EEE, MMM dd, yyyy): " + today.ToString("ddd, MMM dd, yyyy")); // Format 3: EEE, MMM dd, yyyy
    }
}