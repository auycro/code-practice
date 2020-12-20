import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {

    public static void processData(int n){
        String binary = Integer.toBinaryString(n);
        char[] ch = binary.toCharArray();
        
        int consecutive = 0;
        int max_consecutive = 0;
        for(int i=0;i<ch.length;i++){
            
            if (ch[i] == '1')
                consecutive++;
            else
                consecutive = 0;
            
            if (consecutive > max_consecutive)
                max_consecutive = consecutive;
        }
        
        System.out.println(max_consecutive);
    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) {
        int n = scanner.nextInt();
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");
        processData(n);
        scanner.close();
    }
}
