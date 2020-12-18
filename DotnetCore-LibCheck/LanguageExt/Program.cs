using System;
using LanguageExt;
using static LanguageExt.Prelude;
using System.Threading.Tasks;
using System.Linq;

namespace LanguageExt
{
    class Program
    {
        static async Task Main(string[] args)
        {
          await FooBar();

          //string s = "kmretasscityylpdhuwjirnqimlkcgxubxmsxpypgzxtenweirknjtasxtvxemtwxuarabssvqdnktqadhyktagjxoanknhgilnm";
          //int a = s.ToCharArray().Where(x => x =='a').Count();
          //Console.WriteLine(a);

          var temp = Tuple("a","b");
          var t2 = temp.Map((a,b) => $"{a} {b}" );
          Console.WriteLine($"{t2}");

          var t3 = map(temp, (a1,a2) => $"{a1} {a2}");
          Console.WriteLine($"{t3}");
        }

        static async Task FooBar(){
          await Task.Delay(500);
        }
    }
}