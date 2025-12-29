/*Number Guessing Game:
Write a program where the user thinks of a number between 1 and 100, and the computer
tries to guess the number by generating random guesses.
● The user provides feedback by indicating whether the guess is high, low, or correct.
● The program should be modular, with different functions for generating guesses,
receiving user feedback, and determining the next guess.*/
using System;
class GuessNumber
{
    public static void Main(string[] args){
    Console.WriteLine("Choose a number between 1 and 100");
    Console.WriteLine("Type 'h' for higher, 'l' for lower , 'c' for correct.");
    GuessTheNumber();
    }
    public static void GuessTheNumber(){
    int minimum = 1;
    int maximum = 100;
    bool guessed = false;
    while (!guessed){
        int guess = GenerateGuess(minimum, maximum);
        Console.WriteLine($"My guess is: {guess}");
        char reply = GetReply();
        if (reply == 'c'){
        Console.WriteLine("I found the number");
        guessed = true;
        }
        else if (reply == 'h'){
        maximum = guess - 1; // Guess was too high
        }
        else if (reply == 'l'){
        minimum = guess + 1; // Guess was too low
        }else{
        Console.WriteLine("Invalid input");
        }
        if (minimum > maximum){
        Console.WriteLine("u were incorrect");
        break;
        }
        }
    }
    public static int GenerateGuess(int minimum, int maximum){ //generate a random guess between minimum and maximum
    Random rand = new Random();
    return rand.Next(minimum, maximum + 1);
}
    public static char GetReply(){ //Get user reply on the guess
    Console.Write("high,low or correct ");
    return Console.ReadLine().ToLower()[0];
    }
}