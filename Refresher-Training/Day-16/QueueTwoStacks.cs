//https://www.hackerrank.com/challenges/queue-using-two-stacks/problem


using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int q = int.Parse(Console.ReadLine());
        Stack<int> stack1 = new Stack<int>();
        Stack<int> stack2 = new Stack<int>();
        for(int i=0;i<q;i++){
            string[] input = Console.ReadLine().Split();
            int type = int.Parse(input[0]);
            if(type==1){
                int value = int.Parse(input[1]);
                stack1.Push(value);
            }
            else if(type==2){
                if(stack2.Count==0){
                    while(stack1.Count>0){
                        stack2.Push(stack1.Pop());
                    }
                }
                stack2.Pop();
            }
            else if(type==3){
                if(stack2.Count==0){
                    while(stack1.Count>0){
                        stack2.Push(stack1.Pop());
                    }
                }
                Console.WriteLine(stack2.Peek());
            }
        }
    }
}
