using ScreenSoundV3.Menus;
using ScreenSoundV3.Modelos;

namespace ScreenSoundV3
{
    internal class MenuSair : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            System.Console.WriteLine("Tchau tchau ;)");
        }
    }
}