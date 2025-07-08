using System;
using System.Linq;

namespace _1042_sort_simples_beecrowd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int a = int.Parse(vet[0]);
            int b = int.Parse(vet[1]);
            int c = int.Parse(vet[2]);

            int[] numeros = { a, b, c };

            var entrada = numeros;

            var crescente = numeros.OrderBy(n => n);
            foreach(var n in crescente)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();

            foreach (var e in entrada)
            {
                Console.WriteLine(e);
            }

            Console.ReadLine();
        }
    }
}
