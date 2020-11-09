using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

//https://app.codility.com/demo/results/training6P75CV-79G/

// a = 3 -> 11
// b = 3 -> 11
// c = a ^ b -> 00 = 0 

//N = 0..1000000
//N[] = 1..1000000000

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int element = 0;
        for (int i=0; i<A.Count(); i++){
            element ^= A[i];
        }
        return element;
    }
}
