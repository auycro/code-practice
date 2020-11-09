using System;
using System.Collections.Generic;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

//https://app.codility.com/demo/results/trainingF8CYPG-DSC/

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        List<int> list = A.ToList();
        list.Sort();
        
        for(int i=0; i<list.Count(); i++){
            if (list[i] != i+1){
                return 0;
            }
        }
        
        return 1;
    }
}