/*Scenario: Develop a program to manage student test scores. The program should:
● Store the scores of n students in an array.
● Calculate and display the average score.
● Find and display the highest and lowest scores.
● Identify and display the scores above the average.
● Handle invalid input like negative scores or non-numeric input.*/
using System;
class StudentScoreManager
{
    static int[] scores=new int[100];
    static int count = 0;
    static void EnterStudents() //get the number of students
    {
        int number;
        Console.WriteLine("Enter the number of students: ");
        number=Convert.ToInt32(Console.ReadLine());
        if (GetValidInt(number))
        {
            count=number;
            Console.WriteLine("No. of students scored successfully.");

        }
        else
        {
            Console.WriteLine("Please enter a valid positive integer.");
        }
    }
    static void Scores() //get the valid scores of students
    {
        for (int i = 0; i < count; i++){
        Console.Write("Enter score of student " + (i + 1) + ": ");
        scores[i] = Convert.ToInt32(Console.ReadLine());
        while (scores[i] < 0){
        Console.WriteLine("scores cannot be less than 0");
        scores[i] = Convert.ToInt32(Console.ReadLine());
        }
    }
    Console.WriteLine("scores data is saved successfully.");
    }
    static float Average() //calculation of average
    {
        int sum=0;
        for(int i = 0; i < count; i++)
        {
            sum+=scores[i];
        }
        return (float)sum/count;
    }
    static void ShowAverage() // function to show avg score
    {
        if (count == 0)
        {
            Console.WriteLine("Enter scores first");
            return;
        }
        float avg = Average();
        Console.WriteLine("Average score: "+avg);
    }
    static void LowestAndHighest() //to find lowest and highest marks
    {
        if (count == 0){
        Console.WriteLine("Enter scores first.");
        return;
    }
    int highest = scores[0];
    int lowest = scores[0];
    for (int i = 1; i < count; i++){
        if (scores[i] > highest)
        highest = scores[i];
        if (scores[i] < lowest)
        lowest = scores[i];
    }
    Console.WriteLine("Highest Score = " + highest);
    Console.WriteLine("Lowest Score  = " + lowest);
    }
    static void AboveAverageScore()
    {
        if (count == 0){
        Console.WriteLine("Enter scores first.");
        return;
    }
    float avg = Average();
    Console.WriteLine("Scores above average:");
    for (int i = 0; i < count; i++){
        if (scores[i] > avg)
        Console.WriteLine(scores[i]);
        }
    }
    static bool GetValidInt(int number) // get a valid integer
    {
        if (number >= 0)
        {
            return true;
        }
        return false;
    }
    static void Menu()
    {
        while(true){
        Console.WriteLine("--------Welcome to student score manager----------");
        Console.WriteLine("Enter the no. of students: ");
        Console.WriteLine("Enter students score");
        Console.WriteLine("Show the averages of score.");
        Console.WriteLine("Show highest and lowest scores.");
        Console.WriteLine("Show scores above average");
        Console.WriteLine("Exit.");
        Console.WriteLine("Choose from the options above: ");
        string option = Console.ReadLine();
            if (option == "1")
            EnterStudents();
            else if(option=="2") Scores();
            else if(option=="3") ShowAverage();
            else if(option=="4") LowestAndHighest();
            else if(option=="5") AboveAverageScore();
            else if (option == "6")
            {
                Console.WriteLine("Thank you.");
                break;
            }
            else
            {
                Console.WriteLine("Invalid Choice.");
            }
        }
    }
    public static void Main(String[] args)
    {
        Menu();
    }
}
