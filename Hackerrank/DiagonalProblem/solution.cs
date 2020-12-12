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

class Result
{

    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

/*
[i] = row
[j] = column
diagonal from left-top = [0][0] -> [1][1] -> [i][j]
diagonal from right-top = [0][j] -> [1][j-1] -> [i][0]
*/

    public static int diagonalDifference(List<List<int>> arr)
    {
        int sum_from_topleft = 0;
        int sum_from_topright = 0;
        
        int left_index = 0;
        int right_index = arr[0].Count()-1;
        for(int i=0;i<arr.Count();i++){
            var column = arr[i];
            sum_from_topleft+=arr[i][left_index];
            sum_from_topright+=arr[i][right_index];
            left_index++;
            //Console.Out.WriteLine($"{sum_from_topleft},{sum_from_topright}");
            right_index--;
        }
        //Console.Out.WriteLine($"{sum_from_topleft},{sum_from_topright}");
        return Math.Abs(sum_from_topleft - sum_from_topright);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
