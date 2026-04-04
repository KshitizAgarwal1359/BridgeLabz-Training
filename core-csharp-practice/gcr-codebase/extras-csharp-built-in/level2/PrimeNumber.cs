//prime number checker
using System;
class PrimeNumber{
    public static void Main(String[] args){
    Console.Write("Enter a number  ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (IsPrime(number)){
        Console.WriteLine($"{number} is a prime number.");
    }
    else{
        Console.WriteLine($"{number} is not a prime number.");
    }
}
    public static bool IsPrime(int n){ // Function to check if a number is prime
    if (n <= 1) return false;
    for (int i = 2; i <= Math.Sqrt(n); i++){
    if (n % i == 0)
        return false;
    }
    return true;
}
}