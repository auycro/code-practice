using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

// A = int[0...100]
// K = 0...100
// A[x] = -1000...1000

class Solution {
    public int[] solution(int[] A, int K) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        if (A.Count()<1)
            return A;
        
        if (CheckCompleteLoop(A,K))
            return A;
        
        int[] result = A;
        
        for(int i=0;i<K;i++){
            //Console.WriteLine($"{i}:{string.Join(",",result)}");
            result = Moving(result);
        }
        
        return result;
    }
    
    public int[] Moving(int[] input){
        int[] result = new int[input.Count()];
        for(int i=1;i<result.Count();i++){
            //result[i-1]=input[i];
            result[i] = input[i-1];
        }
        result[0] = input[input.Count()-1];
        return result;
    }
    
    public bool CheckCompleteLoop(int[] A, int K){
        return A.Count() == K;
    }
}