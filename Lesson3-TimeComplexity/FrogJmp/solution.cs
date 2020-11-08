using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

//https://app.codility.com/demo/results/trainingH69MSJ-PPT/

class Solution {
    public int solution(int X, int Y, int D) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        if (X>Y)
            return 0;
            
        int jump = Math.Abs(Y - X) / D;
        int distance = X + (jump*D);
        
        Console.WriteLine($"{jump},{distance}");
        
        return ((Y - distance) > 0)? jump+1:jump;
    }
}
