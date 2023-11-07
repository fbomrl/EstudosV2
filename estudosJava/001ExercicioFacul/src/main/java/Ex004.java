import java.util.Locale;
import java.util.Scanner;

public class Ex004 {
    public static void main(String[]args) {

        Scanner sc = new Scanner(System.in);
        Locale.setDefault(Locale.US);

        int n1, n2;
        double quociente, potencia;

        System.out.println("Digite o primeiro número: ");
        n1 = sc.nextInt();
        System.out.println("Digite o segundo número: ");
        n2 = sc.nextInt();

        quociente = (double) n1 / n2;
        potencia= Math.pow(n1, n2);

        System.out.println("O quociente da divisão é: "+ quociente);
        System.out.println("A potência de "+ n1  + " elevado a "+ n2 + "é: "+ potencia);

        sc.close();
    }
}
