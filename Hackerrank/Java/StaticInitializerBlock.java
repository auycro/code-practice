//https://www.hackerrank.com/challenges/java-static-initializer-block/problem
import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

//Write your code here
static boolean flag = false;
static int B;
static int H;

static {
    // whatever code is needed for initialization goes here
    Scanner scan = new Scanner(System.in);
    try {
        B = scan.nextInt();
        H = scan.nextInt();
        if (B <= 0 || H <= 0){
            throw new Exception("Breadth and height must be positive");
        } else {
            flag = true;
        }
    } catch(Exception e){
        System.out.println(e);
    } finally{
        scan.close();
    }
}


public static void main(String[] args){
		if(flag){
			int area=B*H;
			System.out.print(area);
		}
		
	}//end of main

}//end of class

