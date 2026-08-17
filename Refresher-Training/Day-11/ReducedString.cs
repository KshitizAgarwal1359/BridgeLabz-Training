//https://www.hackerrank.com/challenges/reduced-string/problem



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
     * Complete the 'superReducedString' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string superReducedString(string s)
    {
        StringBuilder sb = new StringBuilder();
        for(int i =0;i<s.Length;i++){
            if(sb.Length>0 && sb[sb.Length-1]==s[i]){
                sb.Remove(sb.Length-1,1);
            }
            else{
                sb.Append(s[i]);
            }
        }
        if(sb.Length==0){
            return "Empty String";
        }
        return sb.ToString();
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.superReducedString(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
