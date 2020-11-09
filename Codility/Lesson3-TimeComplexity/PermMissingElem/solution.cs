using System;
using System.Collections.Generic;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

// N = 0...100000
// A[] = 1....100001 
// O(N) or O(N * log(N))

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int N = A.Count();
        
        if (A.Count() < 1)
            return 1;
        
        List<int> list = new List<int>(A);
        list.Sort();
        //Console.WriteLine($"{string.Join(",",list)}");
        var initial = 1;
        for(int i=0;i<list.Count();i++){
            var result = list[i] - initial;
            if (result != 0) {
                //Console.WriteLine(initial);
                return initial;
            }
            initial++;
        }
        
        return N+1;
    }
}