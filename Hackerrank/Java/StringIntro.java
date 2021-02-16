import java.io.*;
import java.util.*;

public class StringIntro {

    public static void main(String[] args) {
        
        Scanner sc=new Scanner(System.in);
        String A=sc.next();
        String B=sc.next();
        /* Enter your code here. Print output to STDOUT. */
        System.out.println(A.length() + B.length());
        String lexical_compare = (A.compareTo(B) > 0) ? "Yes" : "No";
        System.out.println(lexical_compare);
        String captitalize = Character.toUpperCase(A.charAt(0)) + A.substring(1) + " "
                + Character.toUpperCase(B.charAt(0))+B.substring(1);
        System.out.println(captitalize);
        
    }
}