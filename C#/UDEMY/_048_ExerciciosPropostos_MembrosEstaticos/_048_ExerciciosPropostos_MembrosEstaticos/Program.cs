using System;

namespace _048_ExerciciosPropostos_MembrosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Faça um programa para ler a cotação do dólar, e depois um valor em dólares a ser comprado por uma pessoa em reais.Informar quantos reais a pessoa vai pagar pelos dólares, considerando ainda que a pessoa terá que pagar 6 % de IOF sobre o valor em dólar.Criar uma classe ConversorDeMoeda para ser responsável pelos cálculos.");
            Console.WriteLine();
            Console.WriteLine("Qual a cotação do DÓLAR? ");
            double cotacao = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantos dólares você quer comprar? ");
            double quantidade = double.Parse(Console.ReadLine());
            double valorASerPago = ConversorDeMoeda.ConversorDolarParaReal(cotacao, quantidade);
            Console.WriteLine("Valor a ser pago em reais R$ " + valorASerPago.ToString("F2"));

        }
    }
}