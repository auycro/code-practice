using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

//FAILED!! struggle with biggest list.

class Result
{

    /*
     * Complete the 'longestSubarray' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int longestSubarray(List<int> arr)
    {
        int result = 0;
        List<int> max_subarray = new List<int>();

        List<int> checker = new List<int>();        
        List<int> current_subarray = new List<int>();
        checker.Add(arr[0]);
        current_subarray.Add(arr[0]);

        for(int i=1;i<arr.Count;i++){
            create_new_array = true;
            if (checker.Contains(arr[i])){
                current_subarray.Add(arr[i]);
                create_new_array = false;
            } else {
              if (checker.Count() < 2){
                if (!checker.Contains(arr[i])){
                  int differ = (checker[0] > arr[i])? checker[0] - arr[i]: arr[i] - checker[0];
                  if (differ<2) {
                    checker.Add(arr[i]);
                    current_subarray.Add(arr[i]);
                    create_new_array = false;
                  }
                }
              }
            }

            if (create_new_array){
              if (max_subarray.Count < current_subarray.Count){
                max_subarray = current_subarray;
              }
              current_subarray = new List<int>();
              current_subarray.Add(arr[i]);
              checker.Clear();
              checker.Add(arr[i]);
            }          
        }
        
        //Console.WriteLine($"Current: {string.Join(",",current_subarray.ToArray())}"); 
        if (max_subarray.Count < current_subarray.Count){
            max_subarray = current_subarray;
        }
        
        Console.WriteLine($"Max: {string.Join(",",max_subarray.ToArray())}"); 
        return max_subarray.Count;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = new List<int>();

        for (int i = 0; i < arrCount; i++)
        {
            int arrItem = Convert.ToInt32(Console.ReadLine().Trim());
            arr.Add(arrItem);
        }

        int result = Result.longestSubarray(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
