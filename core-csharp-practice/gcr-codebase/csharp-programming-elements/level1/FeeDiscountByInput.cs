using System;
class FeeDiscountByInput{
	public static void Main(){
	Console.Write("Enter fee: ");
	double fee = Convert.ToDouble(Console.ReadLine());
	Console.Write("Enter discount percent: ");
	double discountPercent = Convert.ToDouble(Console.ReadLine());
	double discount = (fee*discountPercent)/100;
	double finalFee = fee - discount;
	Console.WriteLine($"The discount amount is INR {discount} and final discounted fee is INR {finalFee}");
}
}