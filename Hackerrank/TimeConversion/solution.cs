using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the timeConversion function below.
     */
    static string timeConversion(string s) {
        /*
         * Write your code here.
         */
        string result = string.Empty;
        result = s.Substring(0,s.Length-2);     
        if (IsAM(s))
        {
            if (IsTwelve(s)){
                result = "00" + result.Substring(2,result.Length-2);        
            }           
        }
        else {
            if (!IsTwelve(s)){
                int hour = int.Parse(s.Substring(0,2));
                result = (hour+12).ToString() + result.Substring(2,result.Length-2);
            }
        }
        
        return result;
    }
    
    static bool IsTwelve(string s){
        return s.StartsWith("12");
    }
    
    static bool IsAM(string s){
        return s.EndsWith("AM");
    }    

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = timeConversion(s);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}
