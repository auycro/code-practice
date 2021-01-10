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

/***
TESTDATA:
4 5 8
2 4 1
1 9 7
-----
4 3 8 : |5-2| = 2
9 5 1 : |2-9|+|4-5| = 7+1
2 7 6 : |1-2|+|9-7|+|7-6| = 1+2+1
Expected=14

***/

/*** example -> mirror
8 3 4 | 4 3 8
1 5 9 | 9 5 1
6 7 2 | 2 7 6
-----rotate90 -> mirror
4 9 2 | 2 9 4
3 5 7 | 7 5 3
8 1 6 | 6 1 8
-----rotate180 -> mirror
2 7 6 | 6 7 2
9 5 1 | 1 5 9
4 3 8 | 8 3 4
-----rotate270 -> mirror
6 1 8 | 8 1 6
7 5 3 | 3 5 7
2 9 4 | 4 9 2
***/

    // Complete the formingMagicSquare function below.
    static int formingMagicSquareFailed(int[][] s) {
        int result = 0;        
        int[] example = new int[]{1,2,3,4,5,6,7,8,9};
        List<int> sequence_num = new List<int>();
        foreach(var row in s){
            sequence_num.AddRange(row.ToList());
        }
        sequence_num.Sort();
        //Console.WriteLine(String.Join(",", sequence_num));
        
        var duplicates_num = sequence_num.GroupBy(x => x)
                        .Where(group => group.Count() > 1)
                        .Select(group => group.Key).ToList();
        //Console.WriteLine(String.Join(",", duplicates_num));
        
        var missing_num = example.Where(x => !sequence_num.Contains(x)).ToList();
        //Console.WriteLine(String.Join(",", missing_num));
        
        for(int i=0;i<duplicates_num.Count();i++){
            result += Math.Abs(duplicates_num[i] - missing_num[i]);
            //Console.WriteLine(Math.Abs(duplicates_num[i] - missing_num[i]));
        }
        
        return result;
    }

    static int formingMagicSquare(int[][] s){     
        int[][] magic_square = new int[][]{
            new int[]{8,3,4,1,5,9,6,7,2},new int[]{4,3,8,9,5,1,2,7,6},
            new int[]{4,9,2,3,5,7,8,1,6},new int[]{2,9,4,7,5,3,6,1,8},
            new int[]{2,7,6,9,5,1,4,3,8},new int[]{6,7,2,1,5,9,8,3,4},
            new int[]{8,3,4,1,5,9,6,7,2},new int[]{4,3,8,9,5,1,2,7,6},
            new int[]{6,1,8,7,5,3,2,9,4},new int[]{8,1,6,3,5,7,4,9,2},
        };
        
        List<int> sequence = new List<int>();
        foreach(var row in s){
            sequence.AddRange(row.ToList());
        }
        
        int min = int.MaxValue;
        List<int> result_square = new List<int>();
        for (int i=0;i<magic_square.Count();i++){
            int total = 0;
            int[] expect = new int[9];
            for (int j=0;j<sequence.Count();j++){
                total += Math.Abs(sequence[j] - magic_square[i][j]);
                expect[j] = magic_square[i][j];
            }
            if (total<min){
                min = total;
                result_square = expect.ToList();
            }     
        }
        //Console.WriteLine(String.Join(",", result_square));
        
        return min;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int[][] s = new int[3][];

        for (int i = 0; i < 3; i++) {
            s[i] = Array.ConvertAll(Console.ReadLine().Split(' '), sTemp => Convert.ToInt32(sTemp));
        }

        int result = formingMagicSquare(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
