package application;

import util.CurrencyConverter;

import java.util.Locale;
import java.util.Scanner;

public class Program {
    public static void main (String[]args) {
        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);

        System.out.printf("What is the dollar price? ");
        double dollarPrice = sc.nextDouble();

        System.out.printf("How many dollar will be bought? ");
        double dollarQuantity = sc.nextDouble();

        double X = CurrencyConverter.converter(dollarPrice, dollarQuantity);

        System.out.printf("Amount to be paid in reais = %.2f%n", X);



        sc.close();
    }
}
