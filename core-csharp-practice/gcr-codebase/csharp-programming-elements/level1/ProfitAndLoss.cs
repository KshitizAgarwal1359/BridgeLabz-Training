using System;
class ProfitAndLoss{
	public static void Main(){
		double costPrice=129;
		double sellingPrice=191;
		double profit=sellingPrice-costPrice;
		double profitPercent=(profit/costPrice)*100;
		Console.WriteLine("The Cost Price is INR "+costPrice+" and Selling Price is "+sellingPrice);
		Console.WriteLine("The profit is INR "+profit+" and the Profit Percentage is "+profitPercent.ToString("F2"));
	}
}