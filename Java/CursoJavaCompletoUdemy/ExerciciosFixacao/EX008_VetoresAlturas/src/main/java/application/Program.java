package application;

import entities.Pessoas;

import java.util.Locale;
import java.util.Scanner;

public class Program {
    public static void main(String[]args){
        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);

        System.out.println("Quantas Pessoas serão digitadas? ");
        int numeroPessoas = sc.nextInt();
        Pessoas[] vetor = new Pessoas[numeroPessoas];

        for (int i = 0; i < vetor.length; i++) {
            System.out.println("Dados da "+(i+1)+ "a pessoa:");
            sc.nextLine();
            System.out.print("Nome: ");
            String nome = sc.next();
            System.out.print("Idade: ");
            int idade = sc.nextInt();
            System.out.print("Altura: ");
            double altura = sc.nextDouble();

            vetor[i] = new Pessoas(nome, idade, altura);
        }

        double media = 0.00;
        for (int i = 0; i < vetor.length; i++) {
             media +=vetor[i].getAltura();
        }
        double alturamedia = media / vetor.length;
        System.out.printf("Altura média: %.2f", alturamedia);

        int contagemPessoasMenos = 0;
        for(int i = 0; i < vetor.length; i ++) {
            if(vetor[i].getIdade() < 16)
                contagemPessoasMenos += 1;
        }

        double porcentagemIdade = contagemPessoasMenos * 100.0 / vetor.length;
        System.out.println();
        System.out.printf("Pessoas com menos de 16 anos: %.1f%%%n",porcentagemIdade) ;

        for(int i =0; i < vetor.length; i ++) {
            if(vetor[1].getIdade() < 16){
                System.out.println(vetor[i].getNome());
            }

        }
    }
}
