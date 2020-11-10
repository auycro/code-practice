using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    static void Main(string[] args)
    {
        List<string> arr = ReadInput();
        for(int i=0;i<arr.Count();i++){
            var item = arr[i].Split(' ');
            string S = item[0];
            int K = Int32.Parse(item[1]);
            string result = solution(S,K);
            PrintOutput(i, result);
        };
    }
    
    static List<string> ReadInput(){
        int T = Int32.Parse(Console.ReadLine());
        string[] S = new string[T];
        for(int i=0;i<S.Count();i++){
            S[i] = Console.ReadLine();
            //Console.WriteLine(S[i]);
        }
        return S.ToList();
    }
    
    static void PrintOutput (int index, string result){
        Console.WriteLine($"Case #{index}: {result}");
    }
        
    static string solution(string S, int K){
        int result = 3;
        
        
        return result.ToString();   
    }
    
    static List<string> MockData(){
      List<string> result = new List<string>();
      result.Add("---+-++- 3");
      result.Add("+++++ 4");
      result.Add("-+-+- 4");
      return result;
    }
}