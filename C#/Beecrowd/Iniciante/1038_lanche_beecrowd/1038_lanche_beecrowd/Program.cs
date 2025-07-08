using System;
using System.Globalization;

namespace _1038_lanche_beecrowd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');

            int cod = int.Parse(vet[0]);
            int qntd = int.Parse(vet[1]);
            double preco = 0.0;
            switch (cod)
            {
                case 1:
                    preco = 4.00;
                    break;
                case 2:
                    preco = 4.50;
                    break;
                case 3:
                    preco = 5.00;
                    break;
                case 4:
                    preco = 2.00;
                    break;
                case 5:
                    preco = 1.50;
                    break;
            }

            double total = qntd * preco;

           Console.WriteLine($"Total: R$ {total:0.00}");
            Console.ReadLine();
        }
    }
}
