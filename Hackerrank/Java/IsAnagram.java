import java.util.Scanner;

public class Solution {

    static boolean isAnagram(String a, String b){
        char[] char_a = a.toLowerCase().toCharArray();
        char[] char_b = b.toLowerCase().toCharArray();
        
        java.util.Arrays.sort(char_a);
        java.util.Arrays.sort(char_b);
        
        if (java.util.Arrays.equals(char_a, char_b))
            return true;
        
        return false;
    }

    static boolean isAnagramAsDict(String a, String b) {
        // Complete the function
        //System.out.println(a.toLowerCase()+" "+b.toLowerCase());
        java.util.HashMap<Character, Integer> dict = new java.util.HashMap<Character, Integer>();
        char[] a_chr = a.toLowerCase().toCharArray();
        char[] b_chr = b.toLowerCase().toCharArray();
        for(int i=0;i<a_chr.length;i++){
            if (dict.containsKey(a_chr[i])){
                int count = dict.get(a_chr[i])+1;
                dict.put(a_chr[i],count);
            } else {
                dict.put(a_chr[i],1);
            }
        } 
        
        for(int i=0;i<b_chr.length;i++){
            if (dict.containsKey(b_chr[i])){
                int count = dict.get(b_chr[i])-1;
                if (count==0){
                    dict.remove(b_chr[i]);
                } else {
                    dict.put(b_chr[i],count);
                }
            } else {
                return false;
            }
        }
        
        if (dict.size() > 0){
            return false;
        }
        
        return true;
    }

    public static void main(String[] args) {
    
        Scanner scan = new Scanner(System.in);
        String a = scan.next();
        String b = scan.next();
        scan.close();
        boolean ret = isAnagram(a, b);
        System.out.println( (ret) ? "Anagrams" : "Not Anagrams" );
    }
}