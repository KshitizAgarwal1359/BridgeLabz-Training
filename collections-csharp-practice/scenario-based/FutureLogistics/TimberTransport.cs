using System;
//child class that handles timber transportation
public class TimberTransport : GoodsTransport
{
    //timber-specific attributes
    private float timberLength;
    private float timberRadius;
    private string timberType;
    private float timberPrice;
    //constructor to initialize timber and transport details
    public TimberTransport(string transportId, string transportDate, int transportRating,float timberLength, float timberRadius,string timberType, float timberPrice) : base(transportId, transportDate, transportRating)
    {
        this.timberLength = timberLength;
        this.timberRadius = timberRadius;
        this.timberType = timberType;
        this.timberPrice = timberPrice;
    }
    //selects vehicle based on timber surface area
    public override string vehicleSelection()
    {
        double area = 2 * 3.147 * timberRadius * timberLength;
        if (area < 250)
            return "Truck";
        else if (area <= 400)
            return "Lorry";
        else
            return "MonsterLorry";
    }
    //calculates total charge for timber transport
    public override float calculateTotalCharge()
    {
        //calculate timber volume
        double volume = 3.147 * timberRadius * timberRadius * timberLength;
        //determine rate based on timber type
        double rate = timberType.Equals("Premium", StringComparison.OrdinalIgnoreCase) ? 0.25 : 0.15;
        //calculate base price
        double price = volume * timberPrice * rate;
        //apply tax
        double tax = price * 0.30;
        //apply discount based on transport rating
        double discount = 0;
        if (transportRating == 5)
            discount = price * 0.20;
        else if (transportRating == 3 || transportRating == 4)
            discount = price * 0.10;
        //determine vehicle cost
        double vehiclePrice = vehicleSelection().ToLower() switch
        {
            "truck" => 1000,
            "lorry" => 1700,
            _ => 3000
        };
        //final total charge
        return (float)((price + tax + vehiclePrice) - discount);
    }
    //expose timber details
    public string TimberType => timberType;
    public float TimberPrice => timberPrice;
}
