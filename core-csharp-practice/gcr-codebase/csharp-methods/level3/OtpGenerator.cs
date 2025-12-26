//generarte 6 digit otp number using Math random fun
//generate 10 otp numbers and check each number is diffierent
using System;
using System.IO.Pipes;
class OtpGenerator
{
    public static int GenerateOtp()
    {
        Random random = new Random();
        int otp = random.Next(1000000,10000000);
        return otp;
    }
    public static bool AreOtpUnique(int[] otp)
    {
        for(int i = 0; i < otp.Length; i++)
        {
            for(int j = i + 1; j < otp.Length; j++)
            {
                if(otp[i]==otp[j])
                return false;
            }
        }
        return true;
    }
    public static void Main(String[] args)
    {
        int[] otp=new int[10];
        for(int i = 0; i < 10; i++)
        {
            otp[i]=GenerateOtp();
            Console.WriteLine($"Otp generated {i+1}: {otp[i]}");
        }
        bool uni=AreOtpUnique(otp);
        if (uni)
        {
            Console.WriteLine("All otp generated are unique.");
        }
        else
        Console.WriteLine("Duplicate otps found.");
    }
}