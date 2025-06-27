using System;

namespace _072_ModificadorParametroParams
{
    class Calculator
    {
        //Para explicação PARAMS
        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i <numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        //Para explicação REF
        public static void Triple(ref int x)
        {
            x = x * 3;
        }
        //Para explicação OUT
        public static void Triple2(int origin, out int result)
        {
            result = origin * 3;
        }
    }
}
