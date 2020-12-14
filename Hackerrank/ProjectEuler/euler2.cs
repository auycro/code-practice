//https://www.hackerrank.com/contests/projecteuler/challenges/euler002/problem

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            long n = Convert.ToInt64(Console.ReadLine());
            var fibo_list = FibonacciList(n);
            Console.Out.WriteLine(fibo_list.Sum());
        }
    }

    //0,1,1,2,3,5,8,13,21,...N
    public static List<long> FibonacciList(long n){
        List<long> fibonacci_list = new List<long>();
        long Fn_minus_2 = 0;
        long Fn_minus_1 = 1;
        long current = 0;
        
        for(long i=0;i<n;i++){
            current = Fn_minus_1 + Fn_minus_2;
            
            //get only less than n
            if (current > n)
                break;
            
            //Console.Out.WriteLine(current);
            
            //get only even number
            if (current % 2 ==0)
                fibonacci_list.Add(current);
            
            Fn_minus_2 = Fn_minus_1;
            Fn_minus_1 = current;
        }
        
        return fibonacci_list;    
    }
 
//ref: https://www.mathsisfun.com/numbers/fibonacci-sequence.html   
}