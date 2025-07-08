using System;

namespace _1037_Intervalo_beecrowd
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            if (n >= 0.0 && n <= 25.0)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (n > 25.0 && n <= 50.0)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (n > 50.0 && n <= 75.0)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if (n > 75.0 && n <= 100.0)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo"); 
            }

            Console.ReadLine();
        }
    }
}
