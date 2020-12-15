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
        int n = scanner.nextInt();
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");
        PrintMultiply(n);
        scanner.close();
    }
    
    public static void PrintMultiply(int n){
        for(int i=1;i<=10;i++){
            String text = String.format("%s x %s = %s",n,i,n*i);  
            System.out.println(text);
        }
    }
}
