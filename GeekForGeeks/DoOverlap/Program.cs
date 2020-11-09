//https://www.geeksforgeeks.org/find-two-rectangles-overlap/?ref=lbp

using System;

namespace DoOverlap
{
    class Program
    {
        public static void Main(string[] args)
        {
            //RunTest:
            Point t1_l1 = new Point(0,2);
            Point t1_r1 = new Point(2,0);
            Point t1_l2 = new Point(1,3);
            Point t1_r2 = new Point(2,1);

            var t1_result = DoOverlap(t1_l1, t1_r1, t1_l2, t1_r2);

            Console.WriteLine($"t1_result: {t1_result}");
        }

        public static bool DoOverlap(Point l1, Point r1,Point l2,Point r2){
            //Not a Rect
            if (l1.x == r1.x || l1.y == r1.y || l2.x == r2.x || l2.y == r2.y)
              return false;

            // Rect on the left side
            if (l1.x >= r2.x || l2.x >= r1.x)
              return false;

            //Rect under the other
            if (l1.y <= r2.y || l2.y <= r2.y)
              return false;

            return true;
        }
    }

    public class Point {
      public int x {get;set;}
      public int y {get;set;}

      public Point(int x, int y) 
      {
        this.x = x;
        this.y = y;
      }
    }
}
