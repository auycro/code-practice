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

/*
aba,11
10 / 3 = 3
10 % 3 = 2
aba|aba|aba|ab
*/

/*
kmretasscityylpdhuwjirnqimlkcgxubxmsxpypgzxtenweirknjtasxtvxemtwxuarabssvqdnktqadhyktagjxoanknhgilnm
736778906400
51574523448
*/

    // Complete the repeatedString function below.
    static long repeatedString(string s, long n) {
        long repeat = 0;
        repeat = n / s.Length;
        
        int rest = (int)(n % s.Length);
        int a_count = s.ToCharArray().Where(x => x =='a').Count();
        
        string sub = s.Substring(0,rest);
        repeat = (repeat * a_count) + sub.ToCharArray().Where(x => x =='a').Count();
    
        return repeat;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        long n = Convert.ToInt64(Console.ReadLine());

        long result = repeatedString(s, n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
