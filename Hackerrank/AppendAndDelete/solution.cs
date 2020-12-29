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

/* Faiiled-5
y
yu
2
*/

/* Failed-10 
abcd
abcdert
10
*/

    // Complete the appendAndDelete function below.
    static string appendAndDelete(string s, string t, int k) {
        char[] initial = s.ToCharArray();
        char[] desired = t.ToCharArray();
        
        int delete = 0;
        int append = 0;
        
        //delete
        for(int i=0;i<initial.Count();i++){
            if (i > (desired.Count()-1) || initial[i] != desired[i]){
                delete = initial.Count() - i;
                break;
            }
        }
        
        append = desired.Count() - (initial.Count() - delete);
        Console.WriteLine($"{delete},{append}");
        
        //fix failed-5,failed-10
        if (k%2==0 && ((append%2==1)||(delete%2==1))){
            return "No";
        }
        
        return (k>=append+delete)? "Yes":"No";
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string t = Console.ReadLine();

        int k = Convert.ToInt32(Console.ReadLine());

        string result = appendAndDelete(s, t, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
