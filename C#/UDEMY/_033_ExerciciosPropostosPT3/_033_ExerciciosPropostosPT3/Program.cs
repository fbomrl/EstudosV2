using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _033_ExerciciosPropostosPT3
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            void Menu()
            {
                Console.WriteLine("EXERCICIOS SOBRE ESTRUTURA CONDICIONAL (WHILE)");
                Console.WriteLine("Selecionar uma das opções abaixo: ");
                Console.WriteLine("001 - Exercicio 1: ");
                Console.WriteLine("002 - Exercicio 2: ");
                Console.WriteLine("003 - Exercicio 3: ");
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
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;

                }
            }
            void Exercicio01()
            {
                Console.Clear();
                Console.WriteLine("Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha incorreta informada, escrever a mensagem Senha Invalida.Quando a senha for informada corretamente deve ser impressa a mensagem Acesso Permitido e o algoritmo encerrado.Considere que a senha correta é o valor 2002");
                Console.WriteLine();
                Console.Write("Senha: ");
                int senha = int.Parse(Console.ReadLine());
                int senhacorreta = 2002;
                while (senha != senhacorreta)
                {
                    Console.WriteLine("Senha Inválida!");
                    Console.WriteLine();
                    senha = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Acesso Permitido.");
                Console.WriteLine();
                Console.ReadKey();
                Console.Clear();
                Menu();
            }
            void Exercicio02()
            {
                Console.Clear();
                Console.WriteLine("Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema cartesiano.Para cada ponto escrever o quadrante a que ele pertence.O algoritmo será encerrado quando pelo menos uma de duas coordenadas for NULA(nesta situação sem escrever mensagem alguma).");
                string[] coordenadas = Console.ReadLine().Split(' ');
                int x = int.Parse(coordenadas[0]);
                int y = int.Parse(coordenadas[1]);

                while (x != 0 && y != 0)
                {
                    if (x > 0 && y > 0)
                    {
                        Console.WriteLine("Primeiro");
                        Console.WriteLine();
                        Console.WriteLine("Digite novamente: ");
                        coordenadas = Console.ReadLine().Split(' ');
                        x = int.Parse(coordenadas[0]);
                        y = int.Parse(coordenadas[1]);

                    }
                    else if (x < 0 && y > 0)
                    {
                        Console.WriteLine("Segundo");
                        Console.WriteLine();
                        Console.WriteLine("Digite novamente: ");
                        coordenadas = Console.ReadLine().Split(' ');
                        x = int.Parse(coordenadas[0]);
                        y = int.Parse(coordenadas[1]);
                    }
                    else if (x < 0 && y < 0)
                    {
                        Console.WriteLine("Terceiro");
                        Console.WriteLine();
                        Console.WriteLine("Digite novamente: ");
                        coordenadas = Console.ReadLine().Split(' ');
                        x = int.Parse(coordenadas[0]);
                        y = int.Parse(coordenadas[1]);
                    }
                    else if (x > 0 && y < 0)
                    {
                        Console.WriteLine("Quarto");
                        Console.WriteLine();
                        Console.WriteLine("Digite novamente: ");
                        coordenadas = Console.ReadLine().Split(' ');
                        x = int.Parse(coordenadas[0]);
                        y = int.Parse(coordenadas[1]);
                    }
                }

                Console.WriteLine();
                Console.ReadKey();
                Console.Clear();
                Menu();
            }
            void Exercicio03()
            {
                Console.Clear();
                Console.WriteLine("Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva um algoritmo para ler o tipo de combustível abastecido.Caso o usuário informe um código inválido(fora da faixa de 1 a 4) deve ser solicitado um novo código(até que seja válido).O programa será encerrado quando o código informado for o número 4.Deve ser escrito a mensagem: 'MUITO OBRIGADO' e a quantidade de clientes que abasteceram cada tipo de combustível, conforme exemplo");
                Console.WriteLine("1 - Álcool");
                Console.WriteLine("2 - Gasolina");
                Console.WriteLine("3 - Diesel");
                Console.WriteLine("4 - Fim");
                int alcool = 0;
                int gasolina = 0;
                int diesel = 0;
                Console.Write("Escolha uma opção:");
                int entrada = int.Parse(Console.ReadLine());
                while (entrada != 4)
                {
                    if (entrada == 1)
                    {
                        alcool++;
                        Console.Write("..");
                        entrada = int.Parse(Console.ReadLine());
                    }
                    else if (entrada == 2)
                    {
                        gasolina++;
                        Console.Write("..");
                        entrada = int.Parse(Console.ReadLine());
                    }
                    else if (entrada == 3)
                    {
                        diesel++;
                        Console.Write("..");
                        entrada = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("Favor digitar um código válido.");
                        Console.Write("..");
                        entrada = int.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine("MUITO OBRIGADO! ");
                Console.WriteLine("Alcool: " + alcool);
                Console.WriteLine("Gasolina: " + gasolina);
                Console.WriteLine("Diesel: " + diesel);

                Console.WriteLine();
                Console.ReadKey();
                Console.Clear();
                Menu();
            }
        }
    }
}