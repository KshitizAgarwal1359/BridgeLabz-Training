//https://www.hackerrank.com/challenges/ctci-recursive-staircase/problem

using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'stepPerms' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER n as parameter.
     */

    public static int stepPerms(int n)
    {
        if(n==1)
        return 1;
        if(n==2)
        return 2;
        if(n==3)
        return 4;
        int[] d = new int[n+1];
        d[1]=1;
        d[2]=2;
        d[3]=4;
        for(int i=4;i<=n;i++){
            d[i]=d[i-1]+d[i-2]+d[i-3];
        }
        return d[n];
        

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int s = Convert.ToInt32(Console.ReadLine().Trim());

        for (int sItr = 0; sItr < s; sItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            int res = Result.stepPerms(n);

            textWriter.WriteLine(res);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
