using ScreenSoundV3.Modelos;

namespace ScreenSoundV3.Menus
{
    class MenuRegistrarMusica : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            ExibirTituloDaOpcao("Registro de música");
            Console.WriteLine("Digite o nome da Banda");
            string nomeDaBanda = Console.ReadLine();
            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                Console.WriteLine("Agora digite o título do álbum: ");
                string tituloAlbum = Console.ReadLine();
                Banda banda = bandasRegistradas[tituloAlbum];

                if (bandasRegistradas.ContainsKey(tituloAlbum))
                {
                    Console.WriteLine("Digite a música a ser registrada: ");
                    string tituloMusica = Console.ReadLine();
                    //banda.AdicionarMusica(new Musica(tituloMusica));
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