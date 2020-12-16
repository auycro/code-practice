import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner scanner = new Scanner(System.in);
        int n = scanner.nextInt();
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");
        for (int i=0;i<n;i++){
            String s = scanner.nextLine();
            //System.out.println(s);
            ProcessString(s);
        }
        scanner.close();
    }
    
    public static void ProcessString(String str){
        char[] ch = str.toCharArray();
        List<Character> odd_char = new ArrayList<Character>();
        List<Character> even_char = new ArrayList<Character>();
        for(int i=0;i<ch.length;i++){
            if (i%2==0){
                even_char.add(ch[i]);
            } else {
                odd_char.add(ch[i]);
            }
        }
        String even_str = Join(even_char);
        String odd_str = Join(odd_char);
        
        String result = String.format("%s %s",even_str,odd_str);  
        System.out.println(result);
    }
    
    public static String Join(List<Character> char_list){
        StringBuilder sb = new StringBuilder();
        for (char ch : char_list) {
            sb.append(ch);
        }
        return sb.toString();
    }
}