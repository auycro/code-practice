import java.util.regex.Matcher;
import java.util.regex.Pattern;
import java.util.Scanner;

class Solution{

    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        while(in.hasNext()){
            String IP = in.next();
            System.out.println(IP.matches(new MyRegex().pattern));
        }

    }
}

//Write your code here
class MyRegex{    
    static String pattern = "^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";
}


/***
12.12.12.12
13.13.13.112
VUUT.12.12
111.111.11.111
1.1.1.1.1.1.1
.....
1...1..1..1
0.0.0.0
255.0.255.0
266.266.266.266
00000.000000.0000000.00001
0023.0012.0012.0034
-------
true
true
false
true
false
false
false
true
true
false
false
false
***/