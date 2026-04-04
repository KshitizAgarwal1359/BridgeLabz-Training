using System;
class FeeDiscount{
	public static void Main(){
		int fee = 125000;
		int discountPercent = 10;
		int discount = fee/10;
		int feePayble = fee-discount;
		Console.WriteLine($"The discount amount is INR {discount} and final discounted fee is INR {feePayble}");
	}
}