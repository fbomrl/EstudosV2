

namespace ScreenSoundV2.ExternasDesafios
{
    class _Podcast
    {
        public string Host { get; }
        public string Nome { get; }
        public int TotalEpisodios => episodios.Count;

        private List<_Episodio> episodios = new List<_Episodio>();

        public _Podcast(string nome, string host)
        {
            Nome = nome;
            Host = host;
        }

        public void AdicionarEpisodio(_Episodio episodio)
        {
            episodios.Add(episodio);
        }

        public void ExibirDetalhes()
        {

            Console.WriteLine("\n**********PODCAST**********");
            Console.WriteLine($"Podcast {Nome} ----- Apresentado por {Host}\n");
            foreach (_Episodio episodio in episodios.OrderBy(e => e.Ordem))
            {
                Console.WriteLine(episodio.Resumo);
            }
            ;
            Console.WriteLine($"\n\nEste podcast possui {TotalEpisodios} episódios.");
        }
    }
}