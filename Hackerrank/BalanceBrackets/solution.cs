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

    // Complete the isBalanced function below.
    static string isBalanced(string s) {
        Stack<char> brackets = new Stack<char>();
        foreach(char x in s.ToList()){
            if (isOpenBrackets(x)){
                brackets.Push(x);
            } else {
                if (brackets.Count() > 0){
                    char item = brackets.Peek();
                    //Console.WriteLine($"{brackets.Count()}:{item}:{x}");
                    if((item == '[' && x == ']')||
                    (item == '(' && x == ')')||
                    (item == '{' && x == '}')){
                        brackets.Pop();
                    } else {
                        return "NO";
                    }
                }
                else
                    return "NO";
            }
        }
        return (brackets.Count() != 0)? "NO" : "YES";
    }
    
    static bool isOpenBrackets(char s){
        var result = Regex.Match(s.ToString(), @"[\[\(\{]");
        return result.Success;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++) {
            string s = Console.ReadLine();

            string result = isBalanced(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
