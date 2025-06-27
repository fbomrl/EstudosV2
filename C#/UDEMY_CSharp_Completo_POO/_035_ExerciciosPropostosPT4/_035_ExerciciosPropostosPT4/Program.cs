using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _035_ExerciciosPropostosPT4
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            void Menu()
            {
                Console.WriteLine("EXERCICIOS SOBRE ESTRUTURA CONDICIONAL (FOR)");
                Console.WriteLine("Selecionar uma das opções abaixo: ");
                Console.WriteLine("001 - Exercicio 1: ");
                Console.WriteLine("002 - Exercicio 2: ");
                Console.WriteLine("003 - Exercicio 3: ");
                Console.WriteLine("004 - Exercicio 4: ");
                Console.WriteLine("005 - Exercicio 5: ");
                Console.WriteLine("006 - Exercicio 6: ");
                Console.WriteLine("007 - Exercicio 7: ");
                Console.WriteLine("000 - Sair ");
                Console.WriteLine();
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Exercicio01();
                        break;
                    case 2:
                        Exercicio02();
                        break;
                    case 3:
                        Exercicio03();
                        break;
                    case 4:
                        Exercicio04();
                        break;
                    case 5:
                        Exercicio05();
                        break;
                    case 6:
                        Exercicio06();
                        break;
                    case 7:
                        Exercicio07();
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                }

            }
            void Exercicio01()
            {
                Console.Clear();
                Console.WriteLine("Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o X, se for o caso");
                Console.WriteLine();
                int valor = int.Parse(Console.ReadLine());
                int par = 0;
                for (int i = 0; i <= valor; i++)
                {
                    if (par == i % 2)
                    {
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
                Console.WriteLine();
                Console.ReadKey();
                Console.Clear();
                Menu();
            }
            void Exercicio02()
            {
                Console.Clear();
                Console.WriteLine("Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida. Mostre quantos destes valores X estão dentro do intervalo[10, 20] e quantos estão fora do intervalo, mostrando essas informações conforme exemplo(use a palavra 'in' para dentro do intervalo, e 'out' para fora do intervalo).");
                Console.WriteLine();
                Console.WriteLine("Digite um valor de entrada: ");
                int valor = int.Parse(Console.ReadLine());
                int entradas = 0;
                int inn = 0;
                int outt = 0;
                for (int i = 0; i < valor; i++)
                {
                    Console.WriteLine("Entrada: ");
                    entradas = int.Parse(Console.ReadLine());

                    if (entradas >= 10 && entradas <= 20)
                    {
                        inn++;
                    }
                    else
                    {
                        outt++;
                    }
                }
                Console.WriteLine($"{inn} in ");
                Console.WriteLine($"{outt} out ");

                Console.WriteLine();
                Console.ReadKey();
                Console.Clear();
                Menu();
            }
            void Exercicio03()
            {
                Console.Clear();
                Console.WriteLine("Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste de 3 valores reais, cada um deles com uma casa decimal.Apresente a média ponderada para cada um destes conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem peso 5");
                Console.WriteLine();
                Console.WriteLine("Testes: ");
                int testes = int.Parse(Console.ReadLine());

                Console.WriteLine("Testes: " + testes);
                Console.WriteLine();
                for (int i = 0; i < testes; i++)
                {
                    string[] v = Console.ReadLine().Split(' ');
                    double n1 = double.Parse(v[0], CultureInfo.InvariantCulture);
                    double n2 = double.Parse(v[1], CultureInfo.InvariantCulture);
                    double n3 = double.Parse(v[2], CultureInfo.InvariantCulture);

                    double media = (n1 * 2 + n2 * 3 + n3 * 5) / 10.0;

                    Console.WriteLine("Média Ponderada: " + media.ToString("F1", CultureInfo.InvariantCulture));
                }

                Console.WriteLine();
                Console.ReadKey();
                Console.Clear();
                Menu();
            }

            void Exercicio04()
            {
                Console.Clear();
                Console.WriteLine("Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo segundo.Se o denominador for igual a zero, mostrar a mensagem 'divisao impossivel'");
                Console.WriteLine();

                Console.WriteLine("Números: ");
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    string[] v = Console.ReadLine().Split(' ');
                    int a = int.Parse(v[0]);
                    int b = int.Parse(v[1]);

                    double divisao = (double)a / b;
                    if (b == 0)
                    {
                        Console.WriteLine("Divisão Impossível");
                    }
                    else
                    {
                        Console.WriteLine("Divisão: " + divisao);
                    }
                }



                Console.WriteLine();
                Console.ReadKey();
                Console.Clear();
                Menu();
            }
            void Exercicio05()
            {
                Console.Clear();
                Console.WriteLine("Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1. Lembrando que, por definição, fatorial de 0 é 1");
                Console.WriteLine();

                int valorNum = int.Parse(Console.ReadLine());
                int fatorial = 1;

                for (int i = 1; i <= valorNum; i++)
                {
                    fatorial = fatorial * i;

                }
                Console.WriteLine("Fatorial: " + fatorial);

                Console.WriteLine();
                Console.ReadKey();
                Console.Clear();
                Menu();
            }
            void Exercicio06()
            {
                Console.Clear();
                Console.WriteLine("Ler um número inteiro N e calcular todos os seus divisores.");
                Console.WriteLine();
                Console.WriteLine("Número: ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("-----");
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        Console.WriteLine(i);
                    }
                }


                Console.WriteLine();
                Console.ReadKey();
                Console.Clear();
                Menu();
            }
            void Exercicio07()
            {
                Console.Clear();
                Console.WriteLine("Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas, começando de 1 até N.Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme exemplo");
                Console.WriteLine();
                Console.WriteLine("Digite um número positivo: ");
                int n = int.Parse(Console.ReadLine());
                if (n < 0)
                {
                    Console.WriteLine("Digite um número positivo.");
                    Console.Clear();
                    Exercicio07();
                }
                for (int i = 1; i <= n; i++)
                {
                    int quadrado = (int)Math.Pow(i, 2);
                    int cubo = (int)Math.Pow(i, 3);

                    Console.WriteLine($"{i} {quadrado} {cubo}");
                }
                Console.WriteLine();
                Console.ReadKey();
                Console.Clear();
                Menu();
            }
        }
    }
}