using OpenAI_API;
using ScreenSoundV3.Modelos;

namespace ScreenSoundV3.Menus
{
    class MenuRegistrarBanda : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            ExibirTituloDaOpcao("Registro das bandas");
            Console.Write("Digite o nome da banda que deseja registrar: ");
            string nomedaBanda = Console.ReadLine();
            Banda banda = new Banda(nomedaBanda);
            bandasRegistradas.Add(nomedaBanda, banda);

            try
            {
                var client = new OpenAIAPI(""); //Copiar API Key do ChatGPT.
                var chat = client.Chat.CreateConversation();
                chat.AppendSystemMessage($"Resuma a banda {nomedaBanda} em 1 paragrafo, adote um estilo informal");
                string resposta = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult();
                banda.Resumo = resposta;
            }
            catch (Exception)
            {
                Console.WriteLine($"\nA banda {nomedaBanda} foi registrada!");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("\nDeseja registrar outra Banda? (S/N) ");
                string respostaRegistroBanda = Console.ReadLine();
                System.Threading.Thread.Sleep(1000);
                if (respostaRegistroBanda == "S" || respostaRegistroBanda == "s")
                {
                    Executar(bandasRegistradas);
                }
                else
                {
                    Console.Clear();
                }
            }
        }
    }
}