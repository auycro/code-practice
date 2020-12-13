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

class Solution {

    // Complete the hourglassSum function below.

/**
0 -4 -6 0 -7 -6
-1 -2 -6 -8 -3 -1
-8 -4 -2 -8 -8 -6
-3 -1 -2 -5 -7 -4
-3 -5 -3 -6 -6 -6
-3 -6 0 -8 -6 -7

-19
**/
    
    static int? calculateHourglass(int[][] arr, int i, int j){
        if (i+2 > arr.Count()-1)
            return null;
        
        if (j+2 > arr[i].Count()-1)
            return null;

/*
hourglass
 [i][j]    [i][j+1] [i][j+2]
          [i+1][j+1]
 [i+2][j] [i+2][j+2] [i][j+2]
*/

        int sum = 0;
        sum += arr[i][j] + arr[i][j+1] + arr[i][j+2];
        sum += arr[i+1][j+1];
        sum += arr[i+2][j] + arr[i+2][j+1] + arr[i+2][j+2];        
        
        return sum;
    }
    
    static int hourglassSum(int[][] arr) {
        int max = int.MinValue;
        for(int i=0; i<arr.Count()-2; i++){
            for (int j=0; j<arr[i].Count()-2; j++){
                int? sum = calculateHourglass(arr,i,j);
                if (sum != null && sum > max){
                    max = sum.GetValueOrDefault();
                }
            }
        }
        return max;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int[][] arr = new int[6][];

        for (int i = 0; i < 6; i++) {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        int result = hourglassSum(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
