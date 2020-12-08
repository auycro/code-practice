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

namespace CountingValleys
{
  class Program
  {
    public static void Main(string[] args)
    {
      int steps = Convert.ToInt32(Console.ReadLine().Trim());

      string path = Console.ReadLine();

      int result = Result.countingValleys(steps, path);

      Console.WriteLine(result.ToString());
    }
  }

  class Result
  {

    /*
      * Complete the 'countingValleys' function below.
      *
      * The function is expected to return an INTEGER.
      * The function accepts following parameters:
      *  1. INTEGER steps
      *  2. STRING path
      */

    public static int countingValleys(int steps, string path)
    {
      char[] step_list = path.ToCharArray();
      int level = 0;
      int count_valley = 0;
      bool is_valley = false;
      foreach(char step in step_list){
        switch(step){
          case 'U':level++;break;
          case 'D':level--;break; 
        }
        if (level < 0){
          is_valley = true;
        } else if (level >= 0){
          if(is_valley){
            count_valley++;
          }
          is_valley = false;
        }
      }
      return count_valley;
    }

  }
}