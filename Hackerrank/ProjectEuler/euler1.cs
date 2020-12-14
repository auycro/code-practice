//https://www.hackerrank.com/contests/projecteuler/challenges/euler001/problem

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            int n = Convert.ToInt32(Console.ReadLine());
            Sum3(n);
        }
    }
    
    //Timeout Error
    static void Sum(int n){
        int total = 0;
        for(int i=1;i<n;i++){
            if ( i%3==0 || i%5==0 )
                total+=i;
        }
        Console.Out.WriteLine(total);
    }
    
    //Timeout Error
    static void Sum2(int n){
        int total = 0;
        int num_3 = (n-1)/3;
        int num_5 = (n-1)/5;
        int num_15 = (n-1)/15;
        int max_size = (num_3 > num_5)? num_3:num_5; 
        //Console.Out.WriteLine($"{num_3},{num_5},{num_15}");
        for(int i=1;i<max_size+1;i++){
            if ( i <= num_3 ) {
                total += i*3;
            }
            
            if ( i <= num_5 )
                total += i*5;
            
            if ( i <= num_15 )
                total -= i*15;
        }
        Console.Out.WriteLine(total);
    }    
    
    static void Sum3(int n){
        long total = 0;
        long num_3 = (n-1)/3;
        long num_5 = (n-1)/5;
        long num_15 = (n-1)/15;
        //Console.Out.WriteLine($"{num_3},{num_5},{num_15}");
        
        //summation of series c from 1 to k
        //    = k * (a1 + ak)/2
        //    = k * c * (1 + k)/2
        //    = c * k*(k+1)/2
        long sum_3 = 3 * (num_3*(num_3+1)/2);
        long sum_5 = 5 * (num_5*(num_5+1)/2);
        long sum_15 = 15 * (num_15*(num_15+1)/2);
        //Console.Out.WriteLine($"{summation_3},{summation_5},{summation_15}");
        
        total = sum_3 + sum_5 - sum_15;
        Console.Out.WriteLine(total);
    }
}