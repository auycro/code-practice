//https://www.hackerrank.com/challenges/java-loops/problem
import java.util.*;
import java.io.*;
import java.lang.Math; 

class Solution{
    public static void main(String []argh){
        Scanner in = new Scanner(System.in);
        int t=in.nextInt();
        for(int i=0;i<t;i++){
            int a = in.nextInt();
            int b = in.nextInt();
            int n = in.nextInt();
            printSeries(a,b,n);
            System.out.println();
        }
        in.close();
    }
    
    public static int getSequence(int b,int n){
        if (n < 1){
            return 1 * b;
        }
        return ((int)Math.pow(2, n) * b) + getSequence(b,n-1);
    }
    
    public static void printSeries(int a,int b,int n){
        for (int i=0;i<n;i++){
            int result = a + getSequence(b,i);
            System.out.print(String.format("%d ",result));
        } 
    }
}