//https://app.codility.com/c/feedback/7233TX-V5C/

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
        List<int> list = A.ToList();

        if (isAesthetical(list)){
          return 0; 
        }

        int pattern = 0;
        
        for (int i=0; i<list.Count(); i++){
            List<int> trimList = CopyListExcludeElement(list.ToArray(), i);
            if(isAesthetical(trimList)){
                pattern++;
            }
        }
        
        return pattern;
    }
    
    //CheckAesthetical
    public bool isAesthetical(List<int> list){
        int tallerFlag = 0; 
        for(int i=0; i< list.Count(); i++){
           if (tallerFlag == 0){ 
                if (list[i] < list[i+1]){
                    tallerFlag = 1;
                } else {
                    tallerFlag = 2;
                }
           } else {
               if (tallerFlag == 1){
                    if (i%2==1 && list[i] > list[i-1]){
                        
                    } else if (i%2==0 && list[i] < list[i-1]){
                        
                    } else return false;
               } else {
                    if (i%2==1 && list[i] < list[i-1]){
                        
                    } else if ( i % 2 ==0 && list[i] > list[i-1]){
                        
                    } else return false;
               } 
           }
        } 
        
        return true;
    }
    
    public List<int> CopyListExcludeElement(int[] arr, int remove_index){
        int[] result = new int[arr.Count() -1];
        int temp_index = 0;
        for (int i=0; i<arr.Count(); i++){
            if (i != remove_index){
                result[temp_index++] = arr[remove_index];
            }
        }
        return result.ToList();
    }
}
