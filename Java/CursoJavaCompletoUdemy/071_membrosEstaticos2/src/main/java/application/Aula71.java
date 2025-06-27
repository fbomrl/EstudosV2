package application;

import util.Calculator;

import java.util.Locale;
import java.util.Scanner;

public class Aula71 {
    public static void main(String[]args) {

            Locale.setDefault(Locale.US);
            Scanner sc = new Scanner(System.in);

            System.out.printf("Enter Radius: ");
            double radius = sc.nextDouble();

            double c = Calculator.circumference(radius);
            double v = Calculator.volume(radius);

            System.out.printf("Circumference: %.2f%n", c);
            System.out.printf("Volume: %.2f%n", v);
            System.out.printf("Circumference: %.2f%n", Calculator.PI);

            sc.close();
        }

    }

