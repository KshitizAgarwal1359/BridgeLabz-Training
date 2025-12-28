using System;
class NullReference
{
    public static void DemonstrateNullReference()
    {
        string str=null;
        try
        {
            Console.WriteLine("String length: "+str.Length);
        }
        catch(NullReferenceException e)
        {
            Console.WriteLine("Exception caught: NullReferenceException");
            Console.WriteLine("Message: "+e.Message);
        }
    }
    public static void Main(String[] args)
    {
        DemonstrateNullReference();
    }
}