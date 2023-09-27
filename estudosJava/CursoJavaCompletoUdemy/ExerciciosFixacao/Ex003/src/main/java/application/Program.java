package application;

import entities.Student;
import java.util.Locale;
import java.util.Scanner;

public class Program {
    public static void main(String[]args) {
        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);

        Student student = new Student();

        student.name = sc.nextLine();
        student.nota1 = sc.nextDouble();
        student.nota2 = sc.nextDouble();
        student.nota3 = sc.nextDouble();

        System.out.printf("FINAL GRADE = %.2f%n",student.somaNotas());
        if(student.somaNotas() <= 60.0){
            System.out.println("FAILED");
            System.out.printf("MISSING %.2f POINTS%n", student.passouOuNao());
        } else {
            System.out.println("PASS");
        }

    }
}
