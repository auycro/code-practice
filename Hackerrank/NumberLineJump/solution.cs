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

/*TEST CASE 10
43 2 70 2
NO
*/
    // Complete the kangaroo function below.
    static string kangaroo(int x1, int v1, int x2, int v2) {
        // equal_distance = x1 + (v1 * t) = x2 + (v2 * t)
        // x1 + (v1*t) = x2 + (v2*t)
        // (v1*t)-(v2*t) = (x2-x1)
        // t * (v1-v2) = (x2-x1)
        // t = (x2-x1)/(v1-v2)
        
        if (v2 >= v1)
            return "NO";
        
        int jump = 0;
        while (jump != calculate(x1,x2,v1,v2)){
            //NO: when K1 is passing K2
            int k1 = x1 + (v1 * jump);
            int k2 = x2 + (v2 * jump);
            if (k1 > k2)
                return "NO";
            
            jump++;
        }
        
        return "YES";

    }
    
    static int calculate(int x1,int x2, int v1, int v2){
        int start = x2-x1;
        int speed = v1-v2;
        if (start%speed != 0){
            return int.MinValue;
        } else {
            int result = start / speed;
            return result;
        }
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] x1V1X2V2 = Console.ReadLine().Split(' ');

        int x1 = Convert.ToInt32(x1V1X2V2[0]);

        int v1 = Convert.ToInt32(x1V1X2V2[1]);

        int x2 = Convert.ToInt32(x1V1X2V2[2]);

        int v2 = Convert.ToInt32(x1V1X2V2[3]);

        string result = kangaroo(x1, v1, x2, v2);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
