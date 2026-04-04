using System;
//abstract parent class that holds common transport details
public abstract class GoodsTransport
{
    //protected attributes accessible by child classes
    protected string transportId;
    protected string transportDate;
    protected int transportRating;
    //constructor to initialize common transport details
    public GoodsTransport(string transportId, string transportDate, int transportRating)
    {
        this.transportId = transportId;
        this.transportDate = transportDate;
        this.transportRating = transportRating;
    }
    //getter and setter for Transport Id
    public string TransportId
    {
        get { return transportId; }
        set { transportId = value; }
    }
    //getter and setter for Transport Date
    public string TransportDate
    {
        get { return transportDate; }
        set { transportDate = value; }
    }
    //getter and setter for Transport Rating
    public int TransportRating
    {
        get { return transportRating; }
        set { transportRating = value; }
    }
    //abstract method to select vehicle based on transport type
    public abstract string vehicleSelection();
    //abstract method to calculate total transport charge
    public abstract float calculateTotalCharge();
}
