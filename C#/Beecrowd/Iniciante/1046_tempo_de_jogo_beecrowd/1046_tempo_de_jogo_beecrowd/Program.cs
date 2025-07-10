using System;

namespace _1046_tempo_de_jogo_beecrowd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');

            int h1 = int.Parse(vet[0]);
            int h2 = int.Parse(vet[1]);
            int horas = 0;

            if (h2 <= h1)
            {
                h1 = 24 - h1;
                horas = h1 + h2;
            }
            else
            {
                horas = h2 - h1;
            }

            Console.WriteLine($"O JOGO DUROU {horas} HORA(S)");
            Console.ReadLine();
        }
    }
}
