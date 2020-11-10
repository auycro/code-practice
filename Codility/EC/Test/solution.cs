//I didn't try this. But it should work....

using System;
using System.Collections.Generic;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");
namespace Test
{
  class Solution {
    public int solution(int[] A) {
      List<int> list = A.ToList();
      
      //Console.WriteLine(string.Join(",",list));
      if (list.Count() < 2){
        return 0;
      }

      if (list.Count() == 3){
        if (!isAesthetical(list))
          return 1;
      }


      int trimItem = 0;
      for (int i=2; i<list.Count()-1; i++){
          List<int> trimList = CopyThreeItem(list,i);
          //Console.WriteLine(string.Join(",",trimList));
          if(!isAesthetical(trimList)){
            trimItem++;
          }
      }

      return trimItem;
    }

    public bool isAesthetical(List<int> list){
        int index = 1;
        //Console.WriteLine($"Count:{list.Count()},{index}");
        //TST
        if (list[index] > list[index-1]){
          if (list[index] > list[index+1]){
            return true;
          }
        } else {
        //STS
          if (list[index] < list[index-1]){
            if (list[index] < list[index+1]){
              return true;
            }
          }
        }
        //Console.WriteLine($"{string.Join(",",list)}");
        return false;
    }

    public List<int> CopyThreeItem(List<int> arr, int index){
      List<int> result = new List<int>();
      result.Add(arr[index-1]);
      result.Add(arr[index]);
      result.Add(arr[index+1]);
      return result;
    }
  }
}