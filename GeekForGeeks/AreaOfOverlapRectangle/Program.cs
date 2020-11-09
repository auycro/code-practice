using System;

namespace AreaOfOverlapRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //RunTest:
            Point t1_l1 = new Point(2,2);
            Point t1_r1 = new Point(5,7);
            Point t1_l2 = new Point(3,4);
            Point t1_r2 = new Point(6,9);

            var t1_result = TotalOverlapArea(t1_l1, t1_r1, t1_l2, t1_r2);

            Console.WriteLine($"t1_result: {t1_result}");

            //RunTest:
            Point t2_l1 = new Point(2,1);
            Point t2_r1 = new Point(5,5);
            Point t2_l2 = new Point(3,2);
            Point t2_r2 = new Point(5,7);

            var t2_result = TotalOverlapArea(t2_l1, t2_r1, t2_l2, t2_r2);

            Console.WriteLine($"t1_result: {t2_result}");

        }

        public static int TotalOverlapArea(Point l1, Point r1,Point l2,Point r2){
            int left = Math.Max(l1.x, l2.x);
            int right = Math.Min(r1.x, r2.x);
            int bottom = Math.Max(l1.y, l2.y);
            int top = Math.Min(r1.y, r2.y);

            int overlap = 0;
            if (right > left && top > bottom)
              overlap = (right - left) * (top - bottom);

            return overlap;
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
