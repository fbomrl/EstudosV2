package application;

import entities.DadosDaConta;

import java.util.Locale;
import java.util.Scanner;

public class Program {
    public static void main(String[]args) {
        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);

        DadosDaConta dadosDaConta;

        System.out.println("Número da Conta:");
        int numeroConta = sc.nextInt();
        System.out.println("Nome do titular:");
        sc.nextLine();
        String titularConta = sc.nextLine();
        System.out.println("Terá um deposítoo inicial? (S/N) ");
        char resposta = sc.next().charAt(0);
        if(resposta == 'S' || resposta == 's') {
            System.out.println("Digite o valor do depósito inicial: ");
            double depositoInicial = sc.nextDouble();
            dadosDaConta = new DadosDaConta(numeroConta, titularConta, depositoInicial);
        } else {
            dadosDaConta = new DadosDaConta(numeroConta, titularConta);
        }

        System.out.println();
        System.out.println("Dados da conta: ");
        System.out.println(dadosDaConta);

        System.out.println();
        System.out.println("Depósito em conta: ");
        double deposito = sc.nextDouble();
        dadosDaConta.depositoConta(deposito);
        System.out.println("Atualização Conta: ");
        System.out.println(dadosDaConta);

        System.out.println();
        System.out.println("Retirada da conta: ");
        double saque = sc.nextDouble();
        dadosDaConta.retiradaConta(saque);
        System.out.println("Atualização Conta: ");
        System.out.println(dadosDaConta);
    }
}
