using System;
class Quadratic
{
    static double[] FindRoots(double a,double b,double c)
    {
        double delta = Math.Pow(b,2)-4*a*c;
        if (delta < 0)
        {
            return new double[0];
        }
        else if (delta == 0)
        {
            double root= -b/(2*a);
            return new double[] {root};
        }
        else
        {
            double sqrtDelta=Math.Sqrt(delta);
            double root1=(-b+sqrtDelta)/(2*a);
            double root2=(-b-sqrtDelta)/(2*a);
            return new double[] {root1,root2};
        }
    }
    public static void Main(String[] args)
    {
        Console.Write("Enetr value of a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("ENter value of b: ");
        double b=Convert.ToDouble(Console.ReadLine());
        Console.Write("Enetr c: ");
        double c= Convert.ToDouble(Console.ReadLine());
        if (a == 0)
        {
            Console.Write("Invalid a.");
            return;
        }
        double[] roots = FindRoots(a,b,c);
        if (roots.Length == 0)
        {
            Console.WriteLine("No real roots.");
        }
        else if (roots.Length == 1)
        {
            Console.WriteLine("One Root exist.");
            Console.WriteLine("Root= "+roots[0]);
        }
        else
        {
            Console.WriteLine("Two roots exist: ");
            Console.WriteLine("Root1= "+roots[0]);
            Console.WriteLine("Root2= "+roots[1]);
        }
    }
}