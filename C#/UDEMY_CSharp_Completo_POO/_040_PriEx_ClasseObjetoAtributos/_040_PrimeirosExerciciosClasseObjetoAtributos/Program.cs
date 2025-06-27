using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _040_PrimeirosExerciciosClasseObjetoAtributos
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            void Menu()
            {
                Console.WriteLine("1 - Exercicio 01");
                Console.WriteLine("2 - Exercicio 02");
                Console.WriteLine("0 - Sair ");
                Console.WriteLine("Escolha uma opção: ");
                int opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Exercicio01();
                        break;
                    case 2:
                        Exercicio02();
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                }
            }
            void Exercicio01()
            {
                Console.WriteLine();
                Console.WriteLine("Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha.");
                Console.WriteLine();
                Pessoa a, b;
                a = new Pessoa();
                b = new Pessoa();

                Console.WriteLine("Dados da primeira pessoa: ");
                a.Nome = Console.ReadLine();
                Console.WriteLine("Idade:");
                a.Idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Dados da segunda pessoa: ");
                b.Nome = Console.ReadLine();
                Console.WriteLine("Idade:");
                b.Idade = int.Parse(Console.ReadLine());

                if (a.Idade > b.Idade)
                {
                    Console.WriteLine("Pessoa mais Velha: " + a.Nome);
                }
                else
                {
                    Console.WriteLine("Pessoa mais Velha: " + b.Nome);
                }
                Console.WriteLine();
                Console.ReadKey();
                Console.Clear();
                Menu();
            }
            void Exercicio02()
            {
                Console.WriteLine();
                Console.WriteLine("Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário médio dos funcionários");
                Console.WriteLine();

                Funcionario a, b;
                a = new Funcionario();
                b = new Funcionario();

                Console.Write("Nome: ");
                a.Nome = Console.ReadLine();
                Console.Write("Salário R$ ");
                a.Salario = double.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                b.Nome = Console.ReadLine();
                Console.Write("Salário R$ ");
                b.Salario = double.Parse(Console.ReadLine());

                double mediaSalario = (a.Salario + b.Salario) / 2;
                Console.WriteLine("Salário médio R$ " + mediaSalario);

                Console.WriteLine();
                Console.ReadKey();
                Console.Clear();
                Menu();

            }
        }
    }
}