using System;
class HotelBooking
{
    public string guestName;  //global variables
    public string roomType;
    public int nights;
    public HotelBooking() //default constructors
    {
        guestName="Unknown";
        roomType="Standard";
        nights=0;
    }
    public HotelBooking(string g,string r,int n) //parameterized constr.
    {
        guestName=g;
        roomType=r;
        nights=n;
    }
    public HotelBooking(HotelBooking h) //copy constr.
    {
        guestName=h.guestName;
        roomType=h.roomType;
        nights=h.nights;
    }
    public void Display() //dispaly the info.
    {
        Console.WriteLine("guest name: "+guestName);
        Console.WriteLine($"room type: {roomType}");
        Console.WriteLine($"nights to stay: {nights}");
    }
    public static void Main(String[] args)
    {
        HotelBooking b =new HotelBooking(); //calling default constr.
        b.Display();
        HotelBooking b1 = new HotelBooking("Sahil","Standard",4); //parameterized constr.
        b1.Display();
        HotelBooking b2 = new HotelBooking(b1); //copy constructor
        b2.Display();
    }
}