import java.util.Scanner;

public class Teste2 {
    public static void main (String[]args) {
        Scanner sc = new Scanner(System.in);

        Solution solution = new Solution();

        int a = sc.nextInt();
        int[] A = new int[a];
        for (int i = 0; i < a; i++) {
            A[i] = sc.nextInt();
        }
        int K = sc.nextInt();

        boolean result = solution.solution(A, K);

        if (result) {
            System.out.println("Verdadeiro");
        } else {
            System.out.println("Falso");
        }
    }
}
