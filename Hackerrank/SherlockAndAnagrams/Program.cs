using System;

namespace SherlockAndAnagrams
{
    class Program
    {
      static int sherlockAndAnagrams(string s) {

        return 1;
      }
/*****
---Sample Input---
2
ifailuhkqq
kkkk
---Sample Output---
3
10
*****/
      static void Main(string[] args) {
        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++) {
          string s = Console.ReadLine();

          int result = sherlockAndAnagrams(s);

          Console.WriteLine(result);
        }
      }
    }
}
