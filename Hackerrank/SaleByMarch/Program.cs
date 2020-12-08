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

namespace SaleByMarch
{
    class Program
    {
      // Complete the sockMerchant function below.
      static int sockMerchant(int n, int[] ar) {
        List<int> no_pair_sock = new List<int>();
        int pairs_count = 0;
        no_pair_sock.Add(ar[0]);
        
        for(int i=1;i<n;i++){
          if (no_pair_sock.Contains(ar[i])){
            int index = no_pair_sock.IndexOf(ar[i]);
            no_pair_sock.RemoveAt(index);
            pairs_count++;
          } else {
            no_pair_sock.Add(ar[i]);
          }
        }

        return pairs_count;
      }

      static void Main(string[] args) {
          int n = Convert.ToInt32(Console.ReadLine());

          int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
          ;

          int result = sockMerchant(n, ar);

          Console.WriteLine(result.ToString());
      }
    }
}
