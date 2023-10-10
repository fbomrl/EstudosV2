package appplication;

import java.util.Locale;
import java.util.Scanner;

public class Program {
    public static void main(String[]args){
        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);


        System.out.println("Quantos números você vai digitar? ");
        int qntNumero = sc.nextInt();
        int vetor[] = new int[qntNumero];

        for(int i = 0; i < vetor.length; i ++){
            System.out.println("Digite um número: ");
            vetor[i] = sc.nextInt();
        }

        for( int i =0; i < vetor.length; i++){
            if(vetor[i] < 0){
                System.out.println("NÚMEROS NEGATIVOS: " + vetor[i]);
            }

        }


    }
}
