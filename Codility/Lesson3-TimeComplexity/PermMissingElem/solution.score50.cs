using System;
using System.Collections.Generic;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

// A[size] = 1...100001 (max N+1)
// https://app.codility.com/demo/results/trainingQK6938-8BA/

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        List<int> list = new List<int>(A);
        list.Sort();
        string s = string.Join(",",list);
        //Console.WriteLine($"list: {s}");
        for(int i=0; i<list.Count();i++){
            if (list[i+1] != (list[i]+1)) {
                //Console.WriteLine($"missing_item: {list[i]+1}");
                return list[i]+1;
            }
        }
        
        return 0;
    }
}

/***
- empty list and single element
- the first or the last element is missing =
- single element
- two elements
- range sequence, length = ~100,000
***/
