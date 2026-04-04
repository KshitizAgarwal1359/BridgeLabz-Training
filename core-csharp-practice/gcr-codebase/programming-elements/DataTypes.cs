using System;
class DataTypes{
	public static void Main(){
        //Declaring different data types in C# and also initializing and then typecasting
		//All integer types
		byte smallByte=234;
		short smallNumber=-2100;
		int age=35;
		long populationNumber=12345678990909L;
		//float type
		float temperature=35.4f;
		double piValue=3.14;
		decimal bankBalance=100007.56m;
		//Character and string
		char grade='B';
		string name="kshitiz";
		//boolean
		bool isPassed= true;
		//nullable
		int? optional= null;
		//object
		object randomData="Hello c#";
		//Displaying  the values
		Console.WriteLine("Name "+name);
		Console.WriteLine("Age "+age);
		Console.WriteLine("Grade "+grade);
		Console.WriteLine("Passed "+isPassed);
		Console.WriteLine("Balance "+bankBalance);
		
		//now doing typecasting the integer data types into every other integer data type
		//values
		byte byteValue = 10;
		short shortValue = 200;
		int intValue = 300000;
		long longValue = 5000000;
		//implicit casting
		short byteToShort = byteValue;
		int shortToInt = shortValue;
		long intToLong = intValue;
		Console.WriteLine("Implicit");
		Console.WriteLine(byteToShort);
		Console.WriteLine(shortToInt);
		Console.WriteLine(intToLong);
		//explicit casting
		int shortToByte=(byte)shortValue;
		int intToShort=(short)intValue;
		int longToInt = (int)longValue;
		Console.WriteLine("Explicit");
		Console.WriteLine(shortToByte);
		Console.WriteLine(intToShort);
		Console.WriteLine(longToInt);
	}
}
