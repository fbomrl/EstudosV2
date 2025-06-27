using ScreenSoundV3.Menus;
using ScreenSoundV3.Modelos;



namespace ScreenSoundV3

{

    internal class Program

    {

        private static void Main(string[] args)

        {

            Banda linkinPark = new Banda("Linkin Park");

            linkinPark.AdicionarNota(new Avaliacao(10));

            linkinPark.AdicionarNota(new Avaliacao(8));

            linkinPark.AdicionarNota(new Avaliacao(9));



            Banda beatles = new Banda("The Beatles");

            Dictionary<string, Banda> bandasRegistradas = new Dictionary<string, Banda>();

            bandasRegistradas.Add(linkinPark.Nome, linkinPark);

            bandasRegistradas.Add(beatles.Nome, beatles);



            Dictionary<int, Menu> opcoes = new Dictionary<int, Menu>();

            opcoes.Add(1, new MenuRegistrarBanda());

            opcoes.Add(2, new MenuRegistrarAlbum());



            opcoes.Add(4, new MenuMostrarBandasRegistradas());

            opcoes.Add(5, new MenuAvaliarBanda());

            opcoes.Add(6, new MenuAvaliarAlbum());



            opcoes.Add(8, new MenuExibirDetalhes());

            opcoes.Add(0, new MenuSair());



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



            }



            void ExibirOpcoesDoMenu()

            {

                ExibirLogo();

                Console.WriteLine("\nDigite 1 para registrar uma banda");

                Console.WriteLine("Digite 2 para registrar o álbum de uma banda");

                Console.WriteLine("Digite 3 para registrar a música de uma banda");

                Console.WriteLine("Digite 4 para mostrar todas as bandas");

                Console.WriteLine("Digite 5 para avaliar uma banda");

                Console.WriteLine("Digite 6 para avaliar um álbum");

                Console.WriteLine("Digite 7 para avaliar uma música");

                Console.WriteLine("Digite 8 para exibir os detalhes de uma banda");

                Console.WriteLine("Digite 0 para sair");

                Console.Write("\nDigite a sua opção: ");

                string opcaoEscolhida = Console.ReadLine();

                int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);



                if (opcoes.ContainsKey(opcaoEscolhidaNumerica))

                {

                    Menu menuASerExibido = opcoes[opcaoEscolhidaNumerica];

                    menuASerExibido.Executar(bandasRegistradas);

                    if (opcaoEscolhidaNumerica > 0)

                    {

                        ExibirOpcoesDoMenu();

                    }

                }

                else

                {

                    Console.WriteLine("Opção inválida!");

                }

            }



            ExibirOpcoesDoMenu();

        }

    }

}