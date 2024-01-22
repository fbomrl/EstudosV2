using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018_ExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de Escritório";
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';
            double preco1 = 2100.0;
            double preco2 = 650.50;
            double media = 53.23456;

            Console.WriteLine("Produtos: ");
            Console.WriteLine($"{produto1}, cujo preço é $ {preco1}");
            Console.WriteLine($"{produto2}, cujo preço é $ {preco2}");
            Console.WriteLine();
            Console.WriteLine($"Registro: {idade}, código {codigo} e gênero {genero}");
            Console.WriteLine();
            Console.WriteLine($"Medida com oito casas decimais: {media}");
            Console.WriteLine($"Arredondado (três casas decimais): {media:F3}");
            Console.WriteLine($"Separador decimal invariant culture: {media}");

        }
    }
}