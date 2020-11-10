using System;
using System.Collections.Generic;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

//https://app.codility.com/demo/results/demoG39XZD-KA4/

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        List<int> numbers = A.ToList();
        HashSet<int> hashSet = new HashSet<int>(numbers); //distinct
        List<int> positiveNumbers = hashSet.Where(x => x>0).ToList(); // get PositiveNumber
        
        if (positiveNumbers.Count() < 1){
            return 1;
        }
        
        positiveNumbers.Sort();
        
        //Console.WriteLine($"output:{string.Join(",",positiveNumbers)}");
        int target = 1;
        for(int i=0;i<positiveNumbers.Count();i++){
            //Console.WriteLine($"output:{positiveNumbers[i]},{target}");  
            if (positiveNumbers[i] != target) {
                //Console.WriteLine(target);
                return target;
            }
            target++;
        }
        
        return target++;
    }
}