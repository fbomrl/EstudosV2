using System;

namespace _1043_triangulo_beecrowd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            double a = double.Parse(vet[0]);
            double b = double.Parse(vet[1]);
            double c = double.Parse(vet[2]);

            if ((a + b) > c && (b + c) > a && (c + a) > b )
            {
                double p = a + b + c;
                Console.WriteLine($"Perimetro = {p:F1}");
            }
            else
            {
                double t = ((a + b) * c) / 2;
                Console.WriteLine($"Area = {t:F1}");
            }

            Console.ReadLine();
        }
    }
}
