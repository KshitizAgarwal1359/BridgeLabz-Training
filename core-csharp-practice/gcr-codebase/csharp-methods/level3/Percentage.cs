//calculate the total average and percentage of marks of students in physics maths and chemistry
using System;
public class PercentageAndGradeOfStudent{
    public static int[,] GenerateScores(int studentCount){
        Random random = new Random();
        int[,] scores = new int[studentCount, 3];
        for(int i=0; i<studentCount; i++){
        scores[i, 0] = random.Next(10, 100); // Physics
        scores[i, 1] = random.Next(10, 100); // Chemistry
        scores[i, 2] = random.Next(10, 100); // Math
        }
        return scores;
    }
    public static double[,] CalculateResults(int[,] scores, int studentCount){
    double[,] results = new double[studentCount, 3];
    for(int i=0; i<studentCount; i++){
    int total = scores[i, 0] + scores[i, 1] + scores[i, 2];
    double average = total / 3.0;
    double percentage = (total / 300.0) * 100;
    results[i, 0] = total;
    results[i, 1] = Math.Round(average, 2);
    results[i, 2] = Math.Round(percentage, 2);
    }
    return results;
    }
    public static void DisplayScorecard(int[,] scores, double[,] results, int studentCount){
            Console.WriteLine("Student\tPhysics\tChemistry \tMath\tTotal\tAverage\tPercentage");
            for(int i=0; i<studentCount; i++){
            Console.WriteLine($"{i + 1}\t{scores[i, 0]}\t{scores[i, 1]}\t\t{scores[i, 2]}\t{results[i, 0]}\t{results[i, 1]}\t{results[i, 2]}%");
            }
    }
    public static void Main(string[] args){
            Console.WriteLine("Enter the number of students:");
            int studentCount = Convert.ToInt32(Console.ReadLine());
            int[,] scores = GenerateScores(studentCount);
            double[,] results = CalculateResults(scores, studentCount);
            DisplayScorecard(scores, results, studentCount);
    }
}