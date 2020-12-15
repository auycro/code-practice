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

    // Complete the miniMaxSum function below.
    static void miniMaxSum(int[] arr) {
        List<int> sort_arr = arr.ToList();
        sort_arr.Sort();
        long MinSum = 0;
        long MaxSum = 0;
        for(int i=0;i<4;i++){
            MinSum += sort_arr[i];
            MaxSum += sort_arr[sort_arr.Count()-1-i];
        }
        Console.WriteLine($"{MinSum} {MaxSum}");
    }

    static void Main(string[] args) {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        miniMaxSum(arr);
    }
}
