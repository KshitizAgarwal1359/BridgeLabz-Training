//https://www.hackerrank.com/challenges/one-week-preparation-kit-simple-text-editor/problem



using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int q = int.Parse(Console.ReadLine());
        StringBuilder sb = new StringBuilder();
        Stack<string> history = new Stack<string>();
        for(int i =0;i<q;i++){
            string[] input = Console.ReadLine().Split(' ');
            int operation = int.Parse(input[0]);
            if(operation==1){
                history.Push(sb.ToString());
                sb.Append(input[1]);
            }
            else if(operation==2){
                history.Push(sb.ToString());
                int k = int.Parse(input[1]);
                sb.Remove(sb.Length-k,k);
            }
            else if(operation==3){
                int k = int.Parse(input[1]);
                Console.WriteLine(sb[k-1]);
            }
            else if(operation==4){
                sb.Clear();
                sb.Append(history.Pop());
            }
            
        }
    }
}