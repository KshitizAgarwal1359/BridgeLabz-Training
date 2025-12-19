using System;
class Operators{
	public static void Main(){
		//arithmetic operators
		int a=10;
		int b=5;
		Console.WriteLine("Addition "+(a+b));
		Console.WriteLine("Subtraction "+(a-b));
		Console.WriteLine("Multiplication "+(a*b));
		Console.WriteLine("Divison "+(a/b));
		Console.WriteLine("Modulus "+(a%b));
		//relational operation
		Console.WriteLine("a==b "+(a==b));
		Console.WriteLine("a!=b "+(a!=b));
		Console.WriteLine("a>b "+(a>b));
		Console.WriteLine("a<b "+(a<b));
		Console.WriteLine("a>=b "+(a>=b));
		Console.WriteLine("a<=b "+(a<=b));
		//logical operators
		bool isTrue=true;
		bool isFalse=false;
		Console.WriteLine("AND "+(isTrue && isFalse));
		Console.WriteLine("OR "+(isTrue||isFalse));
		Console.WriteLine("NOT "+(!isTrue));
		//Assignment Operators
		int c = 5;
		c+=2;
		Console.WriteLine("+= "+c);
		c-=1;
		Console.WriteLine("-= "+(c));
		c*=2;
		Console.WriteLine("*= "+(c));
		c/=2;
		Console.WriteLine("/= "+(c));
		//Unary Operator
		int x=5;
		Console.WriteLine("x"+x);
		Console.WriteLine("Post-Increment x "+(++x));
		Console.WriteLine("Post-Increment x "+(x++));
		Console.WriteLine("After post-increment x "+(x));
		Console.WriteLine("Pre-decrement x "+(--x));
	}
}