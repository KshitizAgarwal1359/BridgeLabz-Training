using System;
class FestivalLuckyDraw
{
    public static void Main(String[] args)
    {
        int visitor;
        Console.WriteLine("Enter no.of visitors."); //give no. of visitor
        visitor=Convert.ToInt32(Console.ReadLine());
        for(int i = 1; i <= visitor; i++)
        {
            Console.Write($"Visitor {i} enter your lucky number: ");
            int number;
            bool isValid=int.TryParse(Console.ReadLine(), out number);
            if (!isValid)
            {
                Console.WriteLine("Invalid input.");
                continue;
            }
            if(number%3==0 && number % 5 == 0) //check lucky number
            {
                Console.WriteLine("Congrats. You won the draw.");
            }
            else
            {
                Console.WriteLine("Better luck next time.");
            }
        }
        Console.WriteLine("Lucky draw completed. Happy festivals.");
    }
}