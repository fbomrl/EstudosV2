
namespace ScreenSoundV3.Modelos
{
    internal class Album : IAvaliavel
    {
        private List<Musica> musicas = new List<Musica>();
        private List<Avaliacao> notas = new List<Avaliacao>();
        public string Nome { get; }
        public int DuracaoTotal => musicas.Sum(m => m.Duracao);

        public double Media
        {
            get
            {
                if (notas.Count == 0) return 0;
                else return notas.Average(a => a.Nota);
            }
        }

        public static int ContadorDeObjetos = 0;


        public Album(string nome)
        {
            Nome = nome;
            ContadorDeObjetos++;
        }
        public void AdicionarMusica(Musica musica)
        {
            musicas.Add(musica);
        }

        public void ExibirMusicasDoAlbum()
        {
            Console.WriteLine($"Lista de músicas do álbum {Nome}:\n");
            foreach (var musica in musicas)
            {
                Console.WriteLine($"Música: {musica.Nome}");
            }
            Console.WriteLine($"\nPara ouvir esse álbum inteiro você precisa de {DuracaoTotal} segundos\n");
        }

        public void AdicionarNota(Avaliacao nota)
        {
            notas.Add(nota);
        }

        //public static void TesteAlbum()
        //{

        //    Album a1 = new Album("Barões da Pisadinha Ao Vivo");
        //    Album a2 = new Album("Barões da Pisadinha feat.Anitta");
        //    Album a3 = new Album("Barões da Pisadinha no Free Jazz Festival");

        //    Console.WriteLine($"Total de Objetos Criados: {Album.ContadorDeObjetos}");
        //}



    }
}