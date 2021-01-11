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

    // Complete the beautifulDays function below.
    static int beautifulDays(int i, int j, int k) {
        int result = 0;
        for(int day=i;day<=j;day++){
            List<char> rev = day.ToString().ToList();
            rev.Reverse();
            string s = new string(rev.ToArray());
            var beutiful_result = Math.Abs(day - int.Parse(s)) % k;
            //Console.WriteLine($"{day.ToString()},{s},{beutiful_result.ToString()}");
            if (beutiful_result == 0)
                result++;
        }
        return result;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] ijk = Console.ReadLine().Split(' ');

        int i = Convert.ToInt32(ijk[0]);

        int j = Convert.ToInt32(ijk[1]);

        int k = Convert.ToInt32(ijk[2]);

        int result = beautifulDays(i, j, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
