public class Solution {


    public int solution(String S, int[] C) {
        int custoTotal = 0;
        int n = S.length();

        for(int i = 0; i < n - 1; i ++) {
            char atual = S.charAt(i);
            char proximo = S.charAt(i + 1);

                if (Character.isLowerCase(atual) && Character.isLowerCase(proximo)) {
                    if (atual == proximo) {
                        custoTotal += Math.max(C[i], C[i]);
                    }
            }
        }

        return custoTotal;

    }
}
