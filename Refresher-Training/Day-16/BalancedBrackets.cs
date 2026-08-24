//https://www.hackerrank.com/challenges/balanced-brackets/problem


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
     * Complete the 'isBalanced' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string isBalanced(string s)
    {
        Stack<char> stack = new Stack<char>();
        foreach(char c in s){
            if(c=='('||c=='{'||c=='['){
                stack.Push(c);
            }
            else{
                if(stack.Count==0){
                    return "NO";
                }
                char top = stack.Pop();
                if(c==')' && top!='(')
                return  "NO";
                if(c=='}' && top!='{')
                return "NO";
                if(c==']' && top!='[')
                return "NO";
            }
        }
        if(stack.Count==0)
        return "YES";
        
        return "NO";
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string s = Console.ReadLine();

            string result = Result.isBalanced(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
