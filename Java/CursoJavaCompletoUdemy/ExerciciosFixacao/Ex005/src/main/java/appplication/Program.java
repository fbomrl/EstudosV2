package appplication;

import entities.AccountData;

import java.util.Locale;
import java.util.Scanner;

public class Program {
    public static void main(String[]args) {
        Locale.setDefault(Locale.US);
        Scanner sc = new Scanner(System.in);

        AccountData accountData;

        System.out.print("Enter account number: ");
        int account = sc.nextInt();

        System.out.print("Enter account holder: ");
        sc.nextLine();
        String name = sc.nextLine();

        System.out.println("Is there na initial deposit (Y/N)? ");
        char response = sc.next().charAt(0);
        if (response == 'y' || response == 'Y') {
            System.out.println("Enter initial deposit value: ");
            double initialDeposit = sc.nextDouble();
            accountData = new AccountData(account, name, initialDeposit);
        } else {
            accountData = new AccountData(account, name);
        }

        System.out.println();
        System.out.printf("Account data: ");
        System.out.println(accountData);

        System.out.println();
        System.out.print("Enter a deposit value: ");
        double depositValue = sc.nextDouble();
        accountData.depositValue(depositValue);
        System.out.println("Update account data: ");
        System.out.println(accountData);

        System.out.println();
        System.out.println("Enter a withdraw value: ");
        double WithdrawValue = sc.nextDouble();
        accountData.withdrawValue(WithdrawValue);
        System.out.println("Update account data: ");
        System.out.println(accountData);
    }
}
