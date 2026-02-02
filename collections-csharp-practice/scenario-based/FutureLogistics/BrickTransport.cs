using System;
//child class that handles brick transportation
public class BrickTransport : GoodsTransport
{
    //brick-specific attributes
    private float brickSize;
    private int brickQuantity;
    private float brickPrice;
    //constructor to initialize brick and transport details
    public BrickTransport(string transportId, string transportDate, int transportRating,float brickSize, int brickQuantity, float brickPrice)
        : base(transportId, transportDate, transportRating)
    {
        this.brickSize = brickSize;
        this.brickQuantity = brickQuantity;
        this.brickPrice = brickPrice;
    }
    //selects vehicle based on brick quantity
    public override string vehicleSelection()
    {
        if (brickQuantity < 300)
            return "Truck";
        else if (brickQuantity <= 500)
            return "Lorry";
        else
            return "MonsterLorry";
    }
    //calculates total charge including tax, vehicle cost and discount
    public override float calculateTotalCharge()
    {
        //calculate base price
        float price = brickPrice * brickQuantity;
        //apply 30% tax
        float tax = price * 0.30f;
        //calculate discount based on transport rating
        float discount = 0;
        if (transportRating == 5)
            discount = price * 0.20f;
        else if (transportRating == 3 || transportRating == 4)
            discount = price * 0.10f;
        //determine vehicle cost
        float vehiclePrice = vehicleSelection().ToLower() switch
        {
            "truck" => 1000,
            "lorry" => 1700,
            _ => 3000
        };
        //final total charge calculation
        return (price + tax + vehiclePrice) - discount;
    }
    //expose brick details
    public int BrickQuantity => brickQuantity;
    public float BrickPrice => brickPrice;
}
