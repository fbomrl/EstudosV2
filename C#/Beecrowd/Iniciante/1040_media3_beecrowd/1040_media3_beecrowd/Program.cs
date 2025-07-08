using System;

namespace _1040_media3_beecrowd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            double n1 = double.Parse(vet[0]);
            double n2 = double.Parse(vet[1]);
            double n3 = double.Parse(vet[2]);
            double n4 = double.Parse(vet[3]);

            double p1 = 2.0;
            double p2 = 3.0;
            double p3 = 4.0;
            double p4 = 1.0;

            double notalFinal = (n1 * p1 + n2 * p2 + n3 * p3 + n4 * p4) / (p1 + p2 + p3 + p4);
            notalFinal = Math.Truncate(notalFinal * 10) / 10.0;

            Console.WriteLine($"Media: {notalFinal:0.0}");
            if (notalFinal >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (notalFinal < 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else
            {
                Console.WriteLine("Aluno em exame.");
                double exame = double.Parse(Console.ReadLine());
                Console.WriteLine($"Nota do exame: {exame:0.0}");
                double total = (notalFinal + exame) / 2;
                if (total >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine($"Media final: {total:0.0}");
                }
                else if (total < 5.0)
                {
                    Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine($"Media final: {total:0.0}");
                }
            }
            Console.ReadLine();
        }
    }
}
