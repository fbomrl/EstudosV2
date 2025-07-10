using System;

namespace _1044_multiplos_beecrowd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int a = int.Parse(vet[0]);
            int b = int.Parse(vet[1]);

            try
            {
                if (a % b == 0 || b % a == 0)
                {
                    Console.WriteLine("Sao Multiplos");
                }
                else
                {
                    Console.WriteLine("Nao sao Multiplos");
                }
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
