using ScreenSoundV3.Modelos;

namespace ScreenSoundV3.Menus
{
    class MenuRegistrarAlbum : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            ExibirTituloDaOpcao("Registro de álbuns");
            Console.WriteLine("Digite a banda cujo álbum deseja registrar: ");
            string nomeDaBanda = Console.ReadLine();
            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                Console.WriteLine("Agora digite o título do álbum: ");
                string tituloAlbum = Console.ReadLine();
                Banda banda = bandasRegistradas[nomeDaBanda];
                banda.AdicionarAlbum(new Album(tituloAlbum));


                Console.WriteLine($"O álbum {tituloAlbum} de {nomeDaBanda} foi registrado com sucesso!");
                System.Threading.Thread.Sleep(4000);
                Console.Clear();

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