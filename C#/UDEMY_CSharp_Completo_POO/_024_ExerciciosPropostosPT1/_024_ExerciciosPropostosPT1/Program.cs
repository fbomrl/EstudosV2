using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _024_ExerciciosPropostosPT1
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            void Menu()
            {
                Console.WriteLine("Selecionar uma das opções abaixo: ");
                Console.WriteLine("001 - Exercicio 1: ");
                Console.WriteLine("002 - Exercicio 2: ");
                Console.WriteLine("003 - Exercicio 3: ");
                Console.WriteLine("004 - Exercicio 4: ");
                Console.WriteLine("005 - Exercicio 5: ");
                Console.WriteLine("006 - Exercicio 6: ");
                Console.WriteLine("000 - Sair ");
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
                    case 0:

                        Exercicio01();
                        break;

                }
            }

            void Exercicio01()
            {
                Console.WriteLine("Exercício 1: ");
                Console.WriteLine("Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma mensagem explicativa, conforme exemplos");
                Console.WriteLine();
                Console.WriteLine("Primeiro valor: ");
                int n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Segundo valor: ");
                int n2 = int.Parse(Console.ReadLine());
                int soma = n1 + n2;

                Console.WriteLine("SOMA = " + soma);
                Console.ReadKey();
                Console.Clear();
                Menu();
            }
            void Exercicio02()
            {
                Console.WriteLine("Exercício 2: ");
                Console.WriteLine("Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro casas decimais conforme exemplos.");
                Console.WriteLine("Fórmula da área: area = π . raio2");
                Console.WriteLine("Considere o valor de π = 3.14159");

                Console.WriteLine("Valor do raio: ");
                double raio = double.Parse(Console.ReadLine());
                double area = 3.14159 * raio * raio;

                Console.WriteLine("A= " + area.ToString("F4"));
                Console.WriteLine();
                Console.ReadKey();
                Console.Clear();
                Menu();
            }
            void Exercicio03()
            {
                Console.WriteLine("Exercício 3: ");
                Console.WriteLine("Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).");
                Console.WriteLine("Valor A:");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Valor B:");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Valor C:");
                int c = int.Parse(Console.ReadLine());
                Console.WriteLine("Valor D:");
                int d = int.Parse(Console.ReadLine());

                int somaDif = ((a * b) - (c * d));
                Console.WriteLine("DIFERENCA = " + somaDif);
                Console.WriteLine();
                Console.ReadKey();
                Console.Clear();
                Menu();
            }
            void Exercicio04()
            {
                Console.WriteLine("Exercício 4: ");

                Console.WriteLine("Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por hora e calcula o salário desse funcionário.A seguir, mostre o número e o salário do funcionário, com duas casas decimais.");
                Console.WriteLine("Número do Funcionário: ");
                int numFuncionario = int.Parse(Console.ReadLine());
                Console.WriteLine("Número de Horas trabalhadas: ");
                int numHoras = int.Parse(Console.ReadLine());
                Console.WriteLine("Valor da hora trabalhada: ");
                double horasTrabalhadas = double.Parse(Console.ReadLine());
                double salario = numHoras * horasTrabalhadas;

                Console.WriteLine("NUMBER = " + numFuncionario);
                Console.WriteLine("SALARY = U$ " + salario.ToString("F2"));
                Console.WriteLine();
                Console.ReadKey();
                Console.Clear();
                Menu();
            }
            void Exercicio05()
            {
                Console.WriteLine("Exercício 5: ");
                Console.WriteLine("Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2.Calcule e mostre o valor a ser pago.");
                Console.WriteLine("Digite o código, quantidade e valor unitário da primeira peça: ");
                string[] ex5_1 = Console.ReadLine().Split(' ');
                int codPeca1 = int.Parse(ex5_1[0]);
                int numeroPeca1 = int.Parse(ex5_1[1]);
                double valorPeca1 = double.Parse(ex5_1[2]);
                Console.WriteLine("Digite o código, quantidade e valor unitário da segunda peça: ");
                string[] ex5_2 = Console.ReadLine().Split(' ');
                int codPeca2 = int.Parse(ex5_2[0]);
                int numeroPeca2 = int.Parse(ex5_2[1]);
                double valorPeca2 = double.Parse(ex5_2[2]);

                double totalFinal = (numeroPeca1 * valorPeca1) + (numeroPeca2 * valorPeca2);

                Console.WriteLine("VALOR A PAGAR: R$ " + totalFinal.ToString("F2"));

                Console.WriteLine();
                Console.ReadKey();
                Console.Clear();
                Menu();
            }
            void Exercicio06()
            {
                Console.WriteLine("Exercício 6: ");
                Console.WriteLine("Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre: ");
                Console.WriteLine("a) a área do triângulo retângulo que tem A por base e C por altura.");
                Console.WriteLine("b) a área do círculo de raio C. (pi = 3.14159) ");
                Console.WriteLine("c) a área do trapézio que tem A e B por bases e C por altura");
                Console.WriteLine("d) a área do quadrado que tem lado B. ");
                Console.WriteLine("e) a área do retângulo que tem lados A e B.");
                string[] calc = Console.ReadLine().Split(' ');
                Console.WriteLine("Primeiro valor: ");
                double a = double.Parse(calc[0]);
                Console.WriteLine("Segundo valor: ");
                double b = double.Parse(calc[1]);
                Console.WriteLine("Terceiro valor: ");
                double c = double.Parse(calc[2]);

                double triangulo = (a * c) / 2;
                double circulo = (c * c) * 3.14159;
                double trapezio = (a + b) / 2 * c;
                double quadrado = b * b;
                double retangulo = b * a;

                Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3"));
                Console.WriteLine("CIRCULO: " + circulo.ToString("F3"));
                Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3"));
                Console.WriteLine("QUADRADO: " + quadrado.ToString("F3"));
                Console.WriteLine("RETANGULO: " + retangulo.ToString("F3"));

                Console.WriteLine();
                Console.ReadKey();
                Console.Clear();
                Menu();
            }
        }
    }
}