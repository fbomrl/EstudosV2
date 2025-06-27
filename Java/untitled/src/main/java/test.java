import java.util.Arrays;

public class test {

    public static void main(String[] args) throws Exception {
        for(int i = 0 ; i < 4 ; i ++) {
            System.out.print(Arrays.toString(calc(i+1)));
            System.out.print(" ");
        }
    }

    static int[] calc(int number) throws Exception {
        if(number > 0 ) {
            int[] elements = new int[2];
            int cp = number;
            elements[0] = --cp;
            elements[1] = number + 1;
            return elements;
        }
        throw new Exception();
    }
    }

