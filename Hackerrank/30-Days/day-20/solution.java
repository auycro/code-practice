import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        int[] a = new int[n];
        for(int a_i=0; a_i < n; a_i++){
            a[a_i] = in.nextInt();
        }
        // Write Your Code Here
        int swap = 0;
        int first = -1;
        int last = -1;
        
        for (int i=0; i<n; i++) {
            for (int j=0;j<n-1; j++){
                if (a[j]>a[j+1]){
                    int temp = a[j+1];
                    a[j+1] = a[j];
                    a[j] = temp;
                    swap++;
                    //System.out.println(String.format("%d,%d,%d",a[0],a[1],a[2]));
                }
            }
        }
        
        System.out.println(String.format("Array is sorted in %d swaps.",swap));
        System.out.println(String.format("First Element: %d",a[0]));
        System.out.println(String.format("Last Element: %d",a[n-1]));            
    }
}