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

    // Complete the plusMinus function below.
    static void plusMinus(int[] arr) {
        double plus,minus,zero;
        plus=minus=zero=0;
        
        foreach(int x in arr){
            if (x == 0)
                zero++;
                
            if (x < 0)
                minus++;
                
            if (x > 0)
                plus++;
        };
        
        Console.Out.WriteLine(plus/arr.Count());
        Console.Out.WriteLine(minus/arr.Count());
        Console.Out.WriteLine(zero/arr.Count());
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        plusMinus(arr);
    }
}
