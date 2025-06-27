using ScreenSoundV3.Modelos;

namespace ScreenSoundV3.Menus
{
    class MenuAvaliarAlbum : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            ExibirTituloDaOpcao("Avaliar álbum");
            Console.Write("Digite o nome da banda que deseja avaliar: ");
            string nomeDaBanda = Console.ReadLine();
            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                Banda banda = bandasRegistradas[nomeDaBanda];
                Console.WriteLine("Agora digite o título do álbum: ");
                string tituloAlbum = Console.ReadLine();
                if (banda.Albuns.Any(a => a.Nome.Equals(tituloAlbum)))
                {
                    Album album = banda.Albuns.First(a => a.Nome.Equals(tituloAlbum));
                    Console.WriteLine($"Qual a nota que o álbum {tituloAlbum} merece: ");
                    Avaliacao nota = Avaliacao.Parse(Console.ReadLine());
                    album.AdicionarNota(nota);
                    Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para o álbum {tituloAlbum}");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine($"\nO álbum {tituloAlbum} não foi encontrada!");
                    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            else
            {
                Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
                Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}