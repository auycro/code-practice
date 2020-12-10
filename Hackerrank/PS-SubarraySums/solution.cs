using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

//FAILED!! struggle with biggest list.

class Result
{

    /*
     * Complete the 'findSum' function below.
     *
     * The function is expected to return a LONG_INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY numbers
     *  2. 2D_INTEGER_ARRAY queries
     */

    public static List<long> findSum(List<int> numbers, List<List<int>> queries)
    {
        List<long> result = new List<long>();
        
        //Console.WriteLine($"Queries:{queries.Count}");
        for(int i=0;i<queries.Count;i++){
            int start = queries[i][0]; //ShiftIndex
            int end = queries[i][1]; //ShiftIndex
            long addition = queries[i][2];
            
            List<int> sublist = numbers.GetRange(start-1, end - start +1);
            //Console.WriteLine($"Array: {string.Join(",",sublist.ToArray())}");
            List<int> zero_list = sublist.Where(x => x==0).ToList();
            List<int> non_zero_list = sublist.Where(x => x!=0).ToList();
            //Console.WriteLine($"Array: {string.Join(",",zero_list.ToArray())}"); 
            long sum = 0;
            //Console.WriteLine($"NonZero:{non_zero_list.Count}");
            non_zero_list.ForEach(x => {
                sum += x;
            });
            sum += zero_list.Count * addition;
            result.Add(sum);
        }
        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int numbersCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> numbers = new List<int>();

        for (int i = 0; i < numbersCount; i++)
        {
            int numbersItem = Convert.ToInt32(Console.ReadLine().Trim());
            numbers.Add(numbersItem);
        }

        int queriesRows = Convert.ToInt32(Console.ReadLine().Trim());
        int queriesColumns = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> queries = new List<List<int>>();

        for (int i = 0; i < queriesRows; i++)
        {
            queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
        }

        List<long> result = Result.findSum(numbers, queries);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
