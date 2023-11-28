
namespace ScreenSoundV3.Modelos
{
    internal class Musica : IAvaliavel
    {

        private List<Avaliacao> notas = new List<Avaliacao>();
        public string Nome { get; set; }
        public Banda Artista { get; }
        public int Duracao { get; set; }
        public bool Disponivel { get; set; }
        public string DescricaoResumida => $"A música {Nome} pertence à banda {Artista}";

        public double Media
        {
            get
            {
                if (notas.Count == 0) return 0;
                else return notas.Average(a => a.Nota);
            }
        }

        public Musica(Banda artista, string nome)
        {
            Artista = artista;
            Nome = nome;
        }

        public void ExibirFichaTecnica()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Artista: {Artista.Nome}");
            Console.WriteLine($"Duração: {Duracao}");
            if (Disponivel)
            {
                Console.WriteLine("Disponível no plano.\n");
            }
            else
            {
                Console.WriteLine("Adquira o plano Plus+\n");
            }
        }

        public void AdicionarNota(Avaliacao nota)
        {
            notas.Add(nota);
        }
    }
}