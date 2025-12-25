//taking input of 10 students age and check their vote eligibility
using System;
public class StudentVoteChecker
{
    public bool CanStudentVote(int age)
    {
        if (age < 0)
        {
            return false;
        }
        if (age >= 18)
        {
            return true;
        }
        return false;
    }
    public static void Main(String[] args)
    {
        int[] ages = new int[10];
        StudentVoteChecker checker = new StudentVoteChecker();
        for(int i = 0; i < ages.Length; i++)
        {
            Console.Write($"Enter age of student{i+1}: ");
            ages[i]=Convert.ToInt32(Console.ReadLine());
            bool canVote=checker.CanStudentVote(ages[i]);
            if (canVote)
            {
                Console.WriteLine("Student can vote.");
            }
            else
            {
                Console.WriteLine("Student cannot vote.");
            }
        }
    }
}