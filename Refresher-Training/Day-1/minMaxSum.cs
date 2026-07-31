//https://www.hackerrank.com/challenges/mini-max-sum/problem?isFullScreen=true



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
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        long totalSum = 0;
        foreach(int num in arr){
            totalSum +=num;
        }
        long minSum = long.MaxValue;
        long maxSum =  long.MinValue;
        foreach(int num in arr){
            long currentSum = totalSum-num;
            if(currentSum<minSum){
                minSum=currentSum;
            }
            if(currentSum>maxSum){
                maxSum=currentSum;
            }
        }
        Console.WriteLine($"{minSum} {maxSum}");
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
