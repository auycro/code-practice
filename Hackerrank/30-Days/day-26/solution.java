import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner scan = new Scanner(System.in); 
        String return_date = scan.nextLine();
        String due_date = scan.nextLine();
        
        int fine = calculateFine(return_date,due_date);
        System.out.println(fine);
    }
    
    public static int calculateFine(String return_date, String due_date){
        int[] return_data = convertData(return_date);
        int[] due_data = convertData(due_date);
        //System.out.println(Arrays.toString(return_data));
        int years = return_data[2] - due_data[2];
        int months = return_data[1] - due_data[1];
        int days = return_data[0] - due_data[0];
        
        if (years > 0){
            return 10000;
        } else if (months > 0 && years == 0){
            return months * 500;
        } else if (days > 0 && months == 0 && years == 0){
            return days * 15;
        }
        
        return 0;
    }
    
    public static int[] convertData(String data){
        //https://stackoverflow.com/questions/18838781/converting-string-array-to-an-integer-array
        int[] date_int = Arrays.stream(data.split(" ")).mapToInt(Integer::parseInt).toArray();
        return date_int;
    }
}