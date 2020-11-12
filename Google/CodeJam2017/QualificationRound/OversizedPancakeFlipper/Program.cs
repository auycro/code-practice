using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    static bool DEBUG = false;
    static void Main(string[] args)
    {
      DEBUG = args.Where(x=>x.ToLower()=="debug").Count() > 0; 
      DoSolving();
    }
    
    static List<string> ReadInput(){
        List<string> result = new List<string>();
        string test_case = Console.ReadLine();
        int T = Int32.Parse(test_case);
        result.Add(test_case);
        for(int i=0;i<T;i++){
            result.Add(Console.ReadLine);
        }
        return result;
    }
    
    static void PrintOutput (int index, string result){
        Console.WriteLine($"Case #{index}: {result}");
    }
        
    static string solution(string S, int K){
        int result = 3;
        
        
        return result.ToString();   
    }

    static void DoSolving(){
      List<string> arr = (!DEBUG)? ReadInput() : MockData();

      for(int i=0;i<arr.Count();i++){
        var item = arr[i].Split(' ');
        string S = item[0];
        int K = Int32.Parse(item[1]);
        string result = solution(S,K);
        PrintOutput(i, result);
      };
    }

    static List<string> MockData(){
      List<string> result = new List<string>();
      result.Add("3");
      result.Add("---+-++- 3");
      result.Add("+++++ 4");
      result.Add("-+-+- 4");
      return result;
    }
}