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

class Result
{

/***
73
4 2 3 4 4 9 98 98 3 3 3 4 2 98 1 98 98 1 1 4 98 2 98 3 9 9 3 1 4 1 98 9 9 2 9 4 2 2 9 98 4 98 1 3 4 9 1 98 98 4 2 3 98 98 1 99 9 98 98 3 98 98 4 98 2 98 4 2 1 1 9 2 4
----
Expected 22

100
66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66
-----
Expected 100

***/


    /*
     * Complete the 'pickingNumbers' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */

    public static int pickingNumbers(List<int> a)
    {        
        Dictionary<int,int> num_count = new Dictionary<int,int>();
        foreach(var num in a){
            if (!num_count.Keys.Contains(num)){
                num_count.Add(num, 1);
            } else {
                num_count[num] = num_count[num]+1;
            }
        }
        
        num_count = num_count.OrderByDescending(x => x.Value)
                            .ToDictionary(x => x.Key, x => x.Value);
                        
        var result = num_count.Values.ToList()[0];
        var sequence = num_count.Keys.ToList();
        for(int i=0;i<sequence.Count();i++){
            //Console.WriteLine(sequence[i]);
            for (int j=i+1;j<sequence.Count();j++){
                if (Math.Abs(sequence[i] - sequence[j]) <= 1){
                    int p1 = sequence[i];
                    int p2 = sequence[j];
                    //Console.WriteLine($"{p1}:{num_count[p1]},{p2}:{num_count[p2]}");
                    int picking_num_count = num_count[p1] + num_count[p2];
                    if (picking_num_count > result)
                        result = picking_num_count;
                }
            }
        }

        //foreach(var item in num_count){
        //    Console.WriteLine($"{item.Key},{item.Value}");
        //}

        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = Result.pickingNumbers(a);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
