using System;

namespace _1036_Formula_de_Bhaskara_beecrowd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');

            double a = double.Parse(vet[0]);
            double b = double.Parse(vet[1]);
            double c = double.Parse(vet[2]);

            double delta = b * b - 4 * a * c;

            double r1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double r2 = (-b - Math.Sqrt(delta)) / (2 * a);

            if (delta < 0 || a == 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                Console.WriteLine($"R1 = {r1:0.00000}");
                Console.WriteLine($"R2 = {r2:0.00000}");
            }

            Console.ReadLine();
        }
    }
}
