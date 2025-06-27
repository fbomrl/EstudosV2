using ScreenSoundV3.Modelos;


namespace ScreenSoundV3.Menus
{
    class MenuExibirDetalhes : Menu
    {

        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {

            base.Executar(bandasRegistradas);
            ExibirTituloDaOpcao("Exibir Detalhes da banda");
            Console.WriteLine("Digite o nome da banda que deseja conhecer melhor: ");
            string nomeDaBanda = Console.ReadLine();
            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                Banda banda = bandasRegistradas[nomeDaBanda];
                Console.WriteLine(banda.Resumo);
                Console.WriteLine($"\nA média da banda {nomeDaBanda} é {banda.Media}.");
                Console.WriteLine("\nDiscografia: ");

                foreach (Album album in banda.Albuns)
                {
                    Console.WriteLine($"{album.Nome} --> {album.Media}");
                }
                Console.WriteLine("\nDigite uma tecla pra voltar ao menu principal");
                Console.ReadKey();
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