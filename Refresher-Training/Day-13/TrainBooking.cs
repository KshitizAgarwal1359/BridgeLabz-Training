using System;
using System.Collections.Generic;
public class PassengerNode
{
    public int SeatNumber;
    public string PassengerName;
    public PassengerNode Next;
    public PassengerNode(int seatNumber,string passengerName)
    {
        SeatNumber=seatNumber;
        PassengerName=passengerName;
        next=null;
    }
}
public class TrainBooking
{
    private PassengerNode head;
    private Stack<int> cancelledSeats;
    private int maxSeatSoFar;
    public TrainBooking()
    {
        head=null;
        cancelledSeats=new Stack<int>();
        maxSeatSoFar=0;
    }
    public int BookSeat(string passengerName)
    {
        int seatNumber;
        if (cancelledSeats.Count > 0)
        {
            seatNumber=cancelledSeats.Pop();
        }
        else
        {
            maxSeatSoFar++;
            seatNumber=maxSeatSoFar;
        }
        return seatNumber;
    }
    public bool CancelSeat(int seatNumber)
    {
        if(head==null)
        return false;
        if (head.SeatNumber == seatNumber)
        {
            head=head.Next;
            cancelledSeats.Push(seatNumber);
            return true;
        }
        PassengerNode current = head;
        while (current.Next != null)
        {
            if (current.Next.SeatNumber == seatNumber)
            {
                current.Next=current.Next.Next;
                cancelledSeats.Push(seatNumber);
                return true;
            }
            current=current.Next;
        }
        return false;
    }
    public List<PassengerNode> GetPassengerList()
    {
        List<PassengerNode> result = new List<PassengerNode>();
        PassengerNode current = head;
        while (current != null)
        {
            result.Add(current);
            current=current.Next;
        }
        return result;
    }
}
class Program
{
    static void Main()
    {
        TrainBooking b = new TrainBooking();
        Console.WriteLine(b.BookSeat("Kshitiz"));
        Console.WriteLine(b.BookSeat("varun"));
        Console.WriteLine(b.BookSeat("Sohit"));
        b.CancelSeat(2);
        Console.WriteLine(b.BookSeat("Puja"));
        List<PassengerNode> passengers = b.GetPassengerList();
        foreach(PassengerNode p in passengers)
        {
            Console.WriteLine(p.SeatNumber+"-"+p.PassengerName);
        }
    }
}