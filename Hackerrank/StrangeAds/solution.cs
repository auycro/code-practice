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

    // Complete the viralAdvertising function below.
    static int viralAdvertising(int n) {
        int accumulate,liked,shared,watched;
        accumulate = liked = shared = 0;
        watched = 5;
        for (int i=0;i<n;i++){
            liked = (int)Math.Floor((double)watched/2);
            shared = liked * 3;
            accumulate += liked;
            Console.WriteLine($"{i+1}:{watched},{liked},{accumulate}");
            watched = shared;
        }
        return accumulate;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int result = viralAdvertising(n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
