package application;

import entities.DadosConta;

import java.util.Locale;
import java.util.Scanner;

public class Programa {
    public static void main(String[]args){
        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);

        DadosConta dadosConta;

        System.out.print("Número da conta: ");
        int numeroConta = sc.nextInt();

        System.out.print("Titular da conta: ");
        sc.nextLine();
        String titular = sc.nextLine();

        System.out.print("Conta terá um depósito inicial? ");
        char resposta = sc.next().charAt(0);
        if (resposta == 's' || resposta == 'S') {
            System.out.print("O depósito inicial será de R$ :");
            double depositoInicial = sc.nextDouble();
            dadosConta = new DadosConta(numeroConta, titular, depositoInicial);
        } else {
            dadosConta = new DadosConta(numeroConta, titular);
        }

        System.out.println();
        System.out.println("Dados da conta");
        System.out.println(dadosConta);

        System.out.println();
        System.out.println("Valor do depósito R$ ");
        double valor = sc.nextDouble();
        dadosConta.depositoSaldo(valor);
        System.out.println(dadosConta);

        System.out.println();
        System.out.println("Valor do Saque R$ ");
        valor = sc.nextDouble();
        dadosConta.retiradaSaldo(valor);
        System.out.println(dadosConta);
    }
}
