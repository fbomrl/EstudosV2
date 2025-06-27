
namespace ScreenSoundV3.Modelos
{
    internal class Banda : IAvaliavel
    {
        private List<Album> albuns = new List<Album>();
        private List<Avaliacao> notas = new List<Avaliacao>();
        private List<Musica> musicas = new List<Musica>();

        public Banda(string nome)
        {
            Nome = nome;
        }
        public string Resumo { get; set; }
        public string Nome { get; }
        public double Media
        {
            get
            {
                if (notas.Count == 0) return 0;
                else return notas.Average(a => a.Nota);
            }
        }
        public IEnumerable<Album> Albuns => albuns;


        public void AdicionarAlbum(Album album)
        {
            albuns.Add(album);
        }
        public void AdicionarMusica(Musica musica)
        {
            musicas.Add(musica);
        }
        public void AdicionarNota(Avaliacao nota)
        {
            notas.Add(nota);
        }
        public void ExibirDiscografia()
        {
            Console.WriteLine($"Discografia da banda {Nome}");
            foreach (Album album in albuns)
            {
                Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
            }
        }
    }
}