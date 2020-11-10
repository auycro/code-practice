using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //GenerateTestData();
            
            Solution solution = new Solution();
            Console.WriteLine(solution.solution(new int[]{5,4,3,2,6}));
            Console.WriteLine(solution.solution(new int[]{3,7,4,5}));
            Console.WriteLine(solution.solution(new int[]{3,6,4,2}));
            Console.WriteLine(solution.solution(new int[]{4,3,2}));
            Console.WriteLine(solution.solution(new int[]{4,3,2,5,6,9,8}));
        }

        static void GenerateTestData(){
            Random r = new Random();
            int range = 10;
            int rInt = r.Next(0, range); //for ints
            double rDouble = r.NextDouble()* range; //for doubles
            List<string> arr = new List<string>();
            string[] alphabet = new string[]{"a","b","c","d"};

            List<int> list = new List<int>();
            for(int i=0;i<range;i++){
              list.Add(r.Next(0, range));
            }

            List<string> tempList = alphabet.ToList();
            while(arr.Count < alphabet.Count()){
              int size = tempList.Count();
              int index = r.Next(0, size-1);
              string tmp = tempList[index];
              if (!arr.Contains(tmp)){
                arr.Add(tmp);
                tempList.RemoveAt(index);
              }
            }

            Console.WriteLine($"{rInt}");
            Console.WriteLine($"{rDouble}");
            Console.WriteLine($"{string.Join(",",list)}");
            Console.WriteLine($"{string.Join(",",arr)}");
        }
    }
}
