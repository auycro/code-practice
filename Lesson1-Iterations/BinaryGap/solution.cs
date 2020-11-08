using System;
using System.Text.RegularExpressions;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

public class Solution {
    public int solution(int N) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        var result = 0;
        string binary = ConvertToBinary(N);
        result = MaxZeroGap(binary);
        //Console.WriteLine($"{binary},{result}");
        return result;
    }
    
    public string ConvertToBinary(int n){
        string binary = Convert.ToString(n,2);
        return binary;
    }
    
    public int MaxZeroGap(string binary){
        var maxGap = 0;
        
        Regex rgx = new Regex(@"10+");
        
        foreach (Match match in rgx.Matches(binary)) {
            //Console.WriteLine($"Match:{match.Index},{match.Value}");
            if (CheckValidGap(binary, match)) {
                int gap = match.Value.Length -1 ;
                if (gap > maxGap)
                    maxGap = gap;
            }
        }

        return maxGap;
    }
    
    public bool CheckValidGap(string binary, Match m){
        if (binary.Length < m.Index + m.Value.Length +1)
            return false;
       
        string split = binary.Substring(m.Index, m.Value.Length+1);
        
        //Console.WriteLine($"CheckValidGap2:{binary},{m.Index},{m.Value},{split}");
        Regex rgx = new Regex(@"10+1");
        Match result = rgx.Match(split);
            
        return result.Success;
    }
}