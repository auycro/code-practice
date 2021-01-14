//https://www.hackerrank.com/challenges/java-primality-test/problem
//https://docs.oracle.com/javase/7/docs/api/java/math/BigInteger.html#isProbablePrime(int)

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
        //String n = scanner.nextLine();
        BigInteger n = scanner.nextBigInteger();
        boolean result = primeCheck(n);
        if (result) {
            System.out.println("prime");
        } else {
            System.out.println("not prime");
        }
        scanner.close();
    }
    
    public static boolean primeCheck(BigInteger n){
        if (n.isProbablePrime(10)) {
            return true;
        } else {
            return false;
        }
    }
}
