import java.util.Scanner;

public class Teste1 {

    public static void main(String[]args) {
        Scanner sc = new Scanner(System.in);
        String s = sc.next();

        Solution solver = new Solution();

        String resultado = solver.solution(s);


        System.out.println("Resultado: " + resultado);

    }
}
