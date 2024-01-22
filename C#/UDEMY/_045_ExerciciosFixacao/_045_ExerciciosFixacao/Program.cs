using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _045_ExerciciosFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            void Menu()
            {
                Console.WriteLine("EXERCICIOS FIXAÇÃO - CLASSES, ATRIBUTOS E MÉTODOS.");
                Console.WriteLine();
                Console.WriteLine("01 - Exercicio 1.");
                Console.WriteLine("02 - Exercicio 2.");
                Console.WriteLine("03 - Exercicio 3.");
                Console.WriteLine("00 - Sair.");
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
                    case 0:
                        Console.WriteLine("Saindo... ");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        Menu();
                        break;
                }
            }
            void Exercicio01()
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Fazer um programa para ler os valores da largura e altura de um retângulo. Em seguida, mostrar na tela o valor de sua área, perímetro e diagonal.Usar uma classe como mostrado no projeto ao lado.");
                Console.WriteLine();

                Retangulo retangulo = new Retangulo();
                Console.WriteLine("Entre a largura e altura do retângulo:");
                retangulo.Largura = double.Parse(Console.ReadLine());
                retangulo.Altura = double.Parse(Console.ReadLine());

                Console.WriteLine("AREA: " + retangulo.Area().ToString("F2"));
                Console.WriteLine("PERIMETRO: " + retangulo.Perimetro().ToString("F2"));
                Console.WriteLine("DIAGONAL: " + retangulo.Diagonal().ToString("F2"));

                Console.WriteLine();
                Console.ReadKey();
                Console.Clear();
                Menu();
            }
            void Exercicio02()
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Fazer um programa para ler os dados de um funcionário (nome, salário bruto e imposto).Em seguida, mostrar os dados do funcionário(nome e salário líquido).Em seguida, aumentar o salário do funcionário com base em uma porcentagem dada(somente o salário bruto é afetado pela porcentagem) e mostrar novamente os dados do funcionário.Use a classe projetada abaixo.");
                Console.WriteLine();

                Funcionario funcionario = new Funcionario();

                Console.Write("Nome: ");
                funcionario.Nome = Console.ReadLine();
                Console.Write("Salário Bruto: ");
                funcionario.Salario = double.Parse(Console.ReadLine());
                Console.Write("Imposto: ");
                funcionario.Imposto = double.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Funcionário: " + funcionario);
                Console.WriteLine();
                Console.Write("Digite a porcentagem para aumentar o salário: ");
                double porcento = double.Parse(Console.ReadLine());
                funcionario.AumentarSalario(porcento);
                Console.Write("Dados atualizados: " + funcionario);

                Console.WriteLine();
                Console.ReadKey();
                Console.Clear();
                Menu();
            }
            void Exercicio03()
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano (primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada).Ao final, mostrar qual a nota final do aluno no ano.Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam para o aluno obter o mínimo para ser aprovado(que é 60 pontos). Você deve criar uma classe Aluno para resolver este problema");
                Console.WriteLine();
                Aluno aluno = new Aluno();
                Console.Write("Nome do Aluno: ");
                aluno.Nome = Console.ReadLine();
                Console.WriteLine("Digite três notas do aluno: ");
                aluno.notaA = double.Parse(Console.ReadLine());
                aluno.notaB = double.Parse(Console.ReadLine());
                aluno.notaC = double.Parse(Console.ReadLine());

                Console.WriteLine("NOTA FINAL: " + aluno.NotaFinal().ToString("F2"));
                if (aluno.Aprovado())
                {
                    Console.WriteLine("APROVADO");
                }
                else
                {
                    Console.WriteLine("REPROVADO");
                    Console.WriteLine("FALTARAM "
                        + aluno.NotaRestante().ToString("F2")
                        + " PONTOS. ");
                }

                Console.WriteLine();
                Console.ReadKey();
                Console.Clear();
                Menu();
            }
        }
    }
}