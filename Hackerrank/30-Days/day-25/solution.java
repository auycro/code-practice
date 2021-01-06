import java.io.*;
import java.util.*;
import java.lang.Math; 

public class Solution {

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner scan = new Scanner(System.in); 
        int size = Integer.parseInt(scan.nextLine());
        for(int i=0;i<size;i++){
            int data = Integer.parseInt(scan.nextLine());
            printPrime(data);
        }
        scan.close();
    }
    
    public static void printPrime(int data){
        //System.out.println(data);
        if (data == 1){
            System.out.println("Not prime");
            return;
        }
        
        int limit = (int) Math.ceil(Math.sqrt(data));
        //System.out.println(limit);
        for (int i=2;i<=limit;i++){
            if (data != i && data % i == 0){
                System.out.println("Not prime");
                return;
            }
        }
        
        System.out.println("Prime");
    }
}