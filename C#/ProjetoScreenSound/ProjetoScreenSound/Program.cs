﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    class Program
    {

        static void Main(string[] args)
        {
            //Screen Sound
            string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
            Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
            bandasRegistradas.Add("Linkin Park", new List<int> { 10, 9, 8 });
            bandasRegistradas.Add("Beatles", new List<int>());
            void ExibirLogo()
            {
                Console.WriteLine(@"
                

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░

");
                Console.WriteLine(mensagemDeBoasVindas);
            }

            void ExibirOpcoesDoMenu()
            {
                ExibirLogo();
                Console.WriteLine("\nDigite 1 para registrar uma banda");
                Console.WriteLine("Digite 2 para mostrar todas as bandas");
                Console.WriteLine("Digite 3 para avaliar uma banda");
                Console.WriteLine("Digite 4 para exibir a média de uma banda");
                Console.WriteLine("Digite 0 para sair");

                Console.Write("\nDigite a sua opção: ");
                string opcaoEscolhida = Console.ReadLine();
                int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

                switch (opcaoEscolhidaNumerica)
                {
                    case 1:
                        RegistrarBanda();
                        break;
                    case 2:
                        MostrarBandasRegistradas();
                        break;
                    case 3:
                        AvaliarUmaBanda();
                        break;
                    case 4:
                        VerMediaDeUmaBanda();
                        break;
                    case 0:
                        Console.WriteLine("Tchau tchau ;)");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

            }

            void RegistrarBanda()
            {
                Console.Clear();
                ExibirTituloDaOpcao("Registro das bandas");
                Console.Write("Digite o nome da banda que deseja registrar: ");
                string nomedaBanda = Console.ReadLine();
                bandasRegistradas.Add(nomedaBanda, new List<int>());
                Console.WriteLine($"\nA banda {nomedaBanda} foi registrada!");
                Thread.Sleep(2000);
                Console.WriteLine("\nDeseja registrar outra Banda? (S/N) ");
                string respostaRegistroBanda = Console.ReadLine();
                Thread.Sleep(1000);
                if (respostaRegistroBanda == "S" || respostaRegistroBanda == "s")
                {
                    RegistrarBanda();
                }
                else
                {
                    Console.Clear();
                    ExibirOpcoesDoMenu();
                }

            }

            void MostrarBandasRegistradas()
            {
                Console.Clear();
                ExibirTituloDaOpcao("Exibindo todas as bandas registradas");

                foreach (string banda in bandasRegistradas.Keys)
                {
                    Console.WriteLine($"Banda: {banda}");
                }

                Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
                ExibirOpcoesDoMenu();
            }



            void ExibirTituloDaOpcao(string titulo)
            {
                int quantidadeDeLetras = titulo.Length;
                string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
                Console.WriteLine(asteriscos);
                Console.WriteLine(titulo);
                Console.WriteLine(asteriscos + "\n");
            }

            void AvaliarUmaBanda()
            {
                Console.Clear();
                ExibirTituloDaOpcao("Avaliar banda");
                Console.Write("Digite o nome da banda que deseja avaliar: ");
                string nomeDaBanda = Console.ReadLine();

                    if (bandasRegistradas.ContainsKey(nomeDaBanda))
                    {
                        Console.WriteLine($"Entre 0 e 10 - Qual a nota que a banda {nomeDaBanda} merece?");
                        int nota = int.Parse(Console.ReadLine());
                        if (nota < 0 || nota > 10)
                    {
                        Console.WriteLine("Favor digitar uma nota entre 0 e 10.");
                        Thread.Sleep(1000);
                        AvaliarUmaBanda();
                    }
                        bandasRegistradas[nomeDaBanda].Add(nota);
                        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
                        Thread.Sleep(3000);
                        Console.WriteLine($"\nDeseja registrar uma outra nota? (S/N)");
                        string respostaNota = Console.ReadLine();
                        if (respostaNota == "s" || respostaNota == "S")
                        {
                            AvaliarUmaBanda();
                        }
                        else
                        {
                            Console.Clear();
                            ExibirOpcoesDoMenu();
                        }
                    }
                    else
                    {
                        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
                        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
                        Console.ReadKey();
                        Console.Clear();
                        ExibirOpcoesDoMenu();
                    }
            }

            void VerMediaDeUmaBanda()
            {

                //A resolução do problema dada no curso é:

                //List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
                //Console.WriteLine($"\nA média da banda {nomeDaBanda} é {notasDaBanda.Average()}.");
                //Console.WriteLine("Digite uma tecla para voltar ao menu principal.");
                //Console.ReadKey();
                //Console.Clear();
                //ExibirOpcoesDoMenu();


                Console.Clear();
                ExibirTituloDaOpcao("Verificar Média de Avaliação da Banda");
                Console.Write("Qual banda você quer que exiba a média de avaliações? ");
                string nomeDaBandaMedia = Console.ReadLine();
                try
                {
                    if (bandasRegistradas.ContainsKey(nomeDaBandaMedia))
                    {

                        double mediaNotas = bandasRegistradas[nomeDaBandaMedia].Average();

                        Console.WriteLine($"\nA média da banda {nomeDaBandaMedia} é: {mediaNotas}");
                        Thread.Sleep(3000);
                        Console.WriteLine("\nDeseja ver a média de uma outra banda? (S/N)");
                        string resposta = Console.ReadLine();
                        if (resposta == "s" || resposta == "S")
                        {
                            VerMediaDeUmaBanda();
                        }
                        {

                        }
                    }
                    else
                    {
                        Console.WriteLine($"\nA banda {nomeDaBandaMedia} não foi encontrada!");
                        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
                        Console.ReadKey();
                        Console.Clear();
                        ExibirOpcoesDoMenu();
                    }
                }
                catch(InvalidOperationException)
                {
                    Console.WriteLine($"A banda {nomeDaBandaMedia} não tem avaliações para mostrar média");
                    Thread.Sleep(2000);
                    Console.Clear();
                    ExibirOpcoesDoMenu();
                }
            }

            ExibirOpcoesDoMenu();
        }
    }

}
    
