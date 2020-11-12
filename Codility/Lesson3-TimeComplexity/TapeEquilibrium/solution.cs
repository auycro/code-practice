using System;
using System.Collections.Generic;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        List<int> arr = A.ToList();
        int summation,sum_from_left,sum_from_right,minimum;
        summation = sum_from_left = sum_from_right = 0;
        minimum = int.MaxValue;

        for(int i=0; i<arr.Count(); i++){
          sum_from_left += arr[i];
        }

        arr.Reverse();
        for(int i=0; i<arr.Count()-1; i++){
          sum_from_left -= arr[i];
          sum_from_right += arr[i];
          int diff = Math.Abs(sum_from_left - sum_from_right);
          
          if (diff < minimum){
            minimum = diff;
          }
          Console.WriteLine($"{diff},{minimum},{sum_from_left},{sum_from_right}");
        }

        return minimum;
    }
}