//making a console snake and ladder game using only core C# functions
//2 to 4 players can play it.
using System;
class SnakeAndLadder
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Welcome to Snake and Ladder game.");
        int playersCount= GetPlayerCount();
        string[] players=PlayersName(playersCount);
        int[] position = new int[playersCount];
        bool gameComplete = false;
        int currPlayerIndex=0;
        while (!gameComplete)
        {
            string currPlayer = players[currPlayerIndex];
            Console.WriteLine($"It's {currPlayer} turn.Please press enter key.");
            Console.ReadKey(true); 
            int diceValue= RollDice();
            int oldPosition = position[currPlayerIndex];
            int newPosition=oldPosition+diceValue;
            if (newPosition > 100)
            {
                Console.WriteLine($"{currPlayer} rolled {diceValue} but need {100-oldPosition} to win skip chance.");
            }
            else
            {
                position[currPlayerIndex] = MovePlayer(currPlayer,diceValue,oldPosition,newPosition);
                gameComplete=CheckWin(position[currPlayerIndex],players[currPlayerIndex]);

            }
            if(gameComplete)
            break;
            currPlayerIndex=(currPlayerIndex+1)%playersCount;
        }
        Console.WriteLine("Game Over.");
    }
    public static bool CheckWin(int pos,string name)  //check for the 100 position
    {
        if (pos == 100)
        {
            Console.WriteLine($"{name} congratulations you won the game.");
            return true;
        }
        return false;
    }
    public static int MovePlayer(string name,int dice,int oldPosition,int newPosition)  //move player after every click
    {
        Console.WriteLine($"{name} rolled a {dice} moving {oldPosition} to {newPosition}");
        int finPos= SnakeOrLadder(newPosition);
        if (finPos > newPosition)
        Console.WriteLine("Ladder! Climbing up.");
        else if (finPos < newPosition)
        Console.WriteLine("Snake! Bitten.");

        Console.WriteLine($"current position: {finPos}");
        return finPos;
    }
    public static int SnakeOrLadder(int finPos) //check for snake or ladder
    {
        int finalPos = finPos;
        switch (finPos)
        {
            //ladders
            case 3:
            finalPos=45;
            break;
            case 9:
            finalPos=33;
            break;
            case 20:
            finalPos=39;
            break;
            case 42:
            finalPos=61;
            break;
            case 51:
            finalPos=95;
            break;
            case 64:
            finalPos=77;
            break;
            //snake
            case 31:
            finalPos=7;
            break;
            case 39:
            finalPos=16;
            break;
            case 67:
            finalPos=15;
            break;
            case 97:
            finalPos=44;
            break;
            default:
            break;
        }
        return finalPos;
    }
    static Random random = new Random();
    public static int RollDice()  //get 1 to 6 from dice by random
    {
        return random.Next(1,7);
    }
    public static string[] PlayersName(int playersCount) //get players name
    {
        string[] players=new string[playersCount];
        for(int i=0;i<players.Length;i++){
        Console.WriteLine($"ENter player {i+1} name: ");
        players[i]= Console.ReadLine();
        }
        return players;
    }
    public static int GetPlayerCount() //get the count of players
    {
        int number;
    do
    {
        Console.WriteLine("Enter the number of players between 2 to 4:");
        number = Convert.ToInt32(Console.ReadLine());
        if (number < 2 || number > 4)
        {
            Console.WriteLine("Invalid input. Please enter between 2 to 4.");
        }
    } while (number < 2 || number > 4);

    return number;
    }
}