using ScreenSoundV3.Modelos;

namespace ScreenSoundV3.Menus
{
    class MenuAvaliarBanda : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            ExibirTituloDaOpcao("Avaliar banda");
            Console.Write("Digite o nome da banda que deseja avaliar: ");
            string nomeDaBanda = Console.ReadLine();
            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                Banda banda = bandasRegistradas[nomeDaBanda];
                Console.WriteLine($"Qual a nota que a banda {nomeDaBanda} merece: ");
                Avaliacao nota = Avaliacao.Parse(Console.ReadLine());
                banda.AdicionarNota(nota);
                Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para a banda {nomeDaBanda}");
                System.Threading.Thread.Sleep(3000);
                Console.WriteLine($"\nDeseja registrar uma outra nota? (S/N)");
                string respostaNota = Console.ReadLine();
                if (respostaNota == "s" || respostaNota == "S")
                {
                    Executar(bandasRegistradas);
                }
                else
                {
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