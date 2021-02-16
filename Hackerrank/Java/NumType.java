//https://www.hackerrank.com/challenges/java-datatypes/problem

import java.util.*;
import java.io.*;
import java.lang.Math; 

/***
17
9223372036854775808
9223372036854775807
-9223372036854775808
-9223372036854775807
4294967296
4294967295
-4294967296
-4294967295
65536
65535
-65536
-65535
256
255
-256
-255
12222222222222222222222222222222222222222221
---------
9223372036854775808 can't be fitted anywhere.
9223372036854775807 can be fitted in:
* long
-9223372036854775808 can be fitted in:
* long
-9223372036854775807 can be fitted in:
* long
4294967296 can be fitted in:
* long
4294967295 can be fitted in:
* long
-4294967296 can be fitted in:
* long
-4294967295 can be fitted in:
* long
65536 can be fitted in:
* int
* long
65535 can be fitted in:
* int{-truncated-}
***/

class NumType {
    public static void main(String []argh)
    {
        Scanner sc = new Scanner(System.in);
        int t=sc.nextInt();

        //long limit_minus_int = -1 * (long) Math.pow(2,31);
        //System.out.println(limit_minus_int);
        //long limit_int = (long) Math.pow(2,31) - 1;
        //System.out.println(limit_int);
        //long limit_minus_long = -1 * (long) Math.pow(2,63);
        //System.out.println(limit_minus_long);
        //long limit_long = (long) Math.pow(2,63) - 1;
        //System.out.println(limit_long);
        //System.out.println(Long.MIN_VALUE);
        //System.out.println(Long.MAX_VALUE);

        for(int i=0;i<t;i++)
        {

            try
            {   
                long x=sc.nextLong();
                System.out.println(x+" can be fitted in:");
                if(x>=-128 && x<=127) System.out.println("* byte");
                //Complete the code
                if(x>=-32768  && x<=32767) System.out.println("* short");
                if(x>=Integer.MIN_VALUE && x<=Integer.MAX_VALUE) System.out.println("* int");     
                if(x>=Long.MIN_VALUE && x<=Long.MAX_VALUE) System.out.println("* long");
            }
            catch(Exception e)
            {
                System.out.println(sc.next()+" can't be fitted anywhere.");
            }

        }
    }
}



