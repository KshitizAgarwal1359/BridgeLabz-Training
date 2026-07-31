using System;
public class UserInterface
{
    public static void Main()
    {
        Console.WriteLine("Enter the Goods Transport details");
        string input = Console.ReadLine();
        //parse input and create transport object
        Utility utility = new Utility();
        GoodsTransport transport = utility.parseDetails(input);
        //display common transport details
        Console.WriteLine($"Transporter id : {transport.TransportId}");
        Console.WriteLine($"Date of transport : {transport.TransportDate}");
        Console.WriteLine($"Rating of the transport : {transport.TransportRating}");
        //display type-specific details
        if (transport is BrickTransport bt)
        {
            Console.WriteLine($"Quantity of bricks : {bt.BrickQuantity}");
            Console.WriteLine($"Brick price : {bt.BrickPrice}");
        }
        else if (transport is TimberTransport tt)
        {
            Console.WriteLine($"Type of the timber : {tt.TimberType}");
            Console.WriteLine($"Timber price per kilo : {tt.TimberPrice}");
        }
        //display vehicle and total charge
        Console.WriteLine($"Vehicle for transport : {transport.vehicleSelection()}");
        Console.WriteLine($"Total charge : {transport.calculateTotalCharge()}");
    }
}
