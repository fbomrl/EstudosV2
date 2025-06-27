using System;

namespace _1018_Cedulas_beecrowd
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = int.Parse(Console.ReadLine());

            Console.WriteLine(valor);

            int[] notas = { 100, 50, 20, 10, 5, 2, 1};

            foreach (var nota in notas)
            {
                int qntdNotas = valor / nota;
                Console.WriteLine($"{qntdNotas} nota(s) de R$ {nota},00");

                valor %= nota;
            }
            Console.ReadLine();
        }
    }
}
