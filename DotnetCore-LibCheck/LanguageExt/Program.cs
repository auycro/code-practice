using System;
using LanguageExt;
using static LanguageExt.Prelude;
using System.Threading.Tasks;

namespace LanguageExt
{
    class Program
    {
        static async Task Main(string[] args)
        {
          await FooBar();

          var temp = Tuple("a","b");
          var t2 = temp.Map((a,b) => $"{a} {b}" );
          Console.WriteLine($"{t2}");

          var t3 = map(temp, (a1,a2) => $"{a1} {a2}");
          Console.WriteLine($"{t3}");
        }

        static async Task FooBar(){
          await Task.Delay(1000);
        }
    }
}
//using System;class t{static void Main(){int i=2;int[] j = new int[31];j[0]=0;j[1]=1;Console.WriteLine($"{j[0]}\n{j[1]}");while(i<31){j[i]=j[i-1]+j[i-2];Console.WriteLine(j[i]);i++;}}}
