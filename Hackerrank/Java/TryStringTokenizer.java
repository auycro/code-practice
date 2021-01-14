//https://www.hackerrank.com/challenges/java-string-tokens/problem
import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String s = scan.nextLine();
        // Write your code here.
               
        /* This one is failed on "          " case.
        String[] list = s.trim().split("[ !,?._'@]+");
        System.out.println(list.length);
        for(int i=0;i<list.length;i++){
            System.out.println(list[i]);
        }
        */
        
        StringTokenizer st = new StringTokenizer(s, "[A-Z !,?._'@]+");
        System.out.println(st.countTokens());
        while (st.hasMoreTokens()) {
            System.out.println(st.nextToken());
        }
        
        scan.close();
    }
}

