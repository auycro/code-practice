import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {
    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) {
        int[][] arr = new int[6][6];

        for (int i = 0; i < 6; i++) {
            String[] arrRowItems = scanner.nextLine().split(" ");
            scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

            for (int j = 0; j < 6; j++) {
                int arrItem = Integer.parseInt(arrRowItems[j]);
                arr[i][j] = arrItem;
            }
        }
        scanner.close();
        
        hourglassSum(arr);
    }

    public static void hourglassSum(int[][] arr){
        int max = Integer.MIN_VALUE;
        for(int i=0; i<arr.length-2; i++){
            for (int j=0; j<arr[i].length-2; j++){
                int sum = calculateHourglass(arr,i,j);
                if (sum > max){
                    max = sum;
                }
            }
        }
        System.out.println(max);        
    }
    
    public static int calculateHourglass(int[][] arr, int i, int j){
         if (i+2 > arr.length-1)
            return 0;
        
        if (j+2 > arr[i].length-1)
            return 0;

/*
hourglass
 [i][j]    [i][j+1] [i][j+2]
          [i+1][j+1]
 [i+2][j] [i+2][j+2] [i][j+2]
*/

        int sum = 0;
        sum += arr[i][j] + arr[i][j+1] + arr[i][j+2];
        sum += arr[i+1][j+1];
        sum += arr[i+2][j] + arr[i+2][j+1] + arr[i+2][j+2];        
        
        return sum;       
    }
}
