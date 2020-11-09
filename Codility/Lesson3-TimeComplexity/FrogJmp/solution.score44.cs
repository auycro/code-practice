using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

//X,Y,D = 1...1000000000
//https://app.codility.com/demo/results/trainingVSH7X9-VE9/

class Solution {
    public int solution(int X, int Y, int D) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int jump = 0;
        int accumulate_distance = X;
        
        while(IsNotYetArrive(accumulate_distance,Y)){
            accumulate_distance = accumulate_distance +  D;
            //Console.WriteLine($"distance:{accumulate_distance}");
            jump++;
        }
        
        return jump;
    }
    
    public bool IsNotYetArrive(int X, int Y){
        if (X < Y){
            return true;
        }
        return false;
    }
}
