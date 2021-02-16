import java.util.*;
import java.text.*;

public class CurrencyFormat {
    
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        double payment = scanner.nextDouble();
        scanner.close();
        
        // Write your code here.
        //Set<Currency> currencySet = Currency.getAvailableCurrencies();
        //for(Currency c:currencySet){  
        //    System.out.println(c);  
        //}
        
        NumberFormat us_format = NumberFormat.getCurrencyInstance(Locale.US);  
        String us = us_format.format(payment);
        
        NumberFormat in_format = NumberFormat.getCurrencyInstance(new Locale("en", "IN")); 
        String india = in_format.format(payment);
        
        NumberFormat cn_format = NumberFormat.getCurrencyInstance(Locale.CHINA);
        String china = cn_format.format(payment);
        
        NumberFormat eur_format = NumberFormat.getCurrencyInstance(Locale.FRANCE);
        String france = eur_format.format(payment);
        
        System.out.println("US: " + us);
        System.out.println("India: " + india);
        System.out.println("China: " + china);
        System.out.println("France: " + france);
    }
}