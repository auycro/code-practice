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

    // Complete the cutTheSticks function below.
    static int[] cutTheSticks(int[] arr) {
        List<int> result = new List<int>();
        List<int> tree = arr.ToList();
        while (tree.Count() > 0){
            Console.WriteLine(tree.Count());
            result.Add(tree.Count());
            int min = tree.Min();
            
            var temp = new List<int>();
            foreach(var t in tree){
                temp.Add(t - min);
            }        
            //Console.WriteLine(String.Join(",", temp));
            temp.RemoveAll(x => x == 0);         
            tree = temp; 
        }

        return result.ToArray();
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int[] result = cutTheSticks(arr);

        textWriter.WriteLine(string.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
