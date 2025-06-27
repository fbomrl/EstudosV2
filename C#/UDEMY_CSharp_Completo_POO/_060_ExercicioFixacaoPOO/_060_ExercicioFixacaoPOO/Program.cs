using System;

namespace _060_ExercicioFixacaoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            DadosConta conta1;
            Console.Write("Entre com o número da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial? (s/n) ");
            string depInicial = Console.ReadLine();

            if (depInicial == "s" || depInicial == "S")
            {
                Console.Write("Entre com o valor de Depósito Inicial: ");
                double valorInicial = double.Parse(Console.ReadLine());
                conta1 = new DadosConta(nome, conta, valorInicial);
            }
            else
            {
                conta1 = new DadosConta(nome, conta);
            }
            Console.WriteLine();

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta1);
            Console.WriteLine();
            Console.Write("Entre com um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine());
            conta1.Deposito(deposito);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta1);
            Console.WriteLine();
            Console.Write("Entre com um valor para saque: ");
            double saque = double.Parse(Console.ReadLine());
            conta1.Saque(saque);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta1);
            Console.WriteLine();

        }
    }
}