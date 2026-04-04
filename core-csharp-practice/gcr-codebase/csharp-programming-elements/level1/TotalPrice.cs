using System;
class TotalPrice{
	public static void Main(String[] args){
		Console.Write("Enter unit price: ");
		int unitPrice = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter quantity: ");
		int quantity = Convert.ToInt32(Console.ReadLine());
		int totalPrice = unitPrice*quantity;
		Console.WriteLine($"The total purchase price is INR {totalPrice} if the quantity {quantity} and unit price is INR {unitPrice}");
		
	}
}