using System;
class FriendComparison
{
    public static void Main(String[] args)
    {
        Console.Write("Enter Amar's age: "); //for aman
        int amarAge = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Amar's height in cm: ");
        int amarHeight = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Akbar's age: "); //for akbar
        int akbarAge = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Akbar's height in cm: ");
        int akbarHeight = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Anthony's age: "); //for anthony
        int anthonyAge = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Anthony's height in cm: ");
        int anthonyHeight = Convert.ToInt32(Console.ReadLine());
        int youngestAge = amarAge;
        string youngestFriend = "Amar";
        if (akbarAge < youngestAge)
        {
            youngestAge = akbarAge;
            youngestFriend = "Akbar";
        }
        if (anthonyAge < youngestAge)
        {
            youngestAge = anthonyAge;
            youngestFriend = "Anthony";
        }
        double tallestHeight = amarHeight;
        string tallestFriend = "Amar";
        if (akbarHeight > tallestHeight)
        {
            tallestHeight = akbarHeight;
            tallestFriend = "Akbar";
        }
        if (anthonyHeight > tallestHeight)
        {
            tallestHeight = anthonyHeight;
            tallestFriend = "Anthony";
        }
        Console.WriteLine("\nYoungest Friend: " + youngestFriend + " (Age: " + youngestAge + ")");
        Console.WriteLine("Tallest Friend: " + tallestFriend + " (Height: " + tallestHeight + " cm)");
    }
}