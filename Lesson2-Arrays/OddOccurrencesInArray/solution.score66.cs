using System;
using System.Collections.Generic;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

//N = 0..1000000
//N[] = 1..1000000000

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int result = 0;
        
        // HashTable of matched, index
        Dictionary<int,int> pairs = new Dictionary<int,int>();
        //Console.WriteLine(list[0]);
        for(int i=0;i<A.Count();i++){
            if (IsUsed(i, pairs))
                continue;
                
            if (IsPair(i, A, pairs)){
                continue;
            }
            
            return A[i];
        }
        
        return result;
    }
    
    public bool IsUsed(int index, Dictionary<int,int> pairs){
        if (pairs.ContainsKey(index)){
            //Console.WriteLine($"Contains {i},{pairs[i]}");
            return true;
        }
        return false;
    }
    
    public bool IsPair(int target,int[] list,Dictionary<int,int> pairs){
        for(int j=target+1; j<list.Count(); j++){
            if (list[target] == list[j]){
                Console.WriteLine($"Match {target},{j}:{list[target]}");
                pairs.Add(j,target);
                return true;
            }
        }
        return false;
    }

/***
  O(N**2)
  Timeout Error
  medium random test n=100,003
  big random test n=999,999, multiple repetitions
  big random test n=999,999
***/
}
