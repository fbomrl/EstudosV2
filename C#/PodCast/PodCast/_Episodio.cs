

namespace ScreenSoundV2.ExternasDesafios
{
    class _Episodio
    {

        private List<string> convidados = new List<string>();
        public int Duracao { get; }
        public int Ordem { get; }
        public string Resumo => $"{Ordem}. {Titulo} (Duração: {Duracao} min) - {string.Join(", ", convidados)}";
        public string Titulo { get; }


        public _Episodio(string titulo, int duracao, int ordem)
        {
            Titulo = titulo;
            Duracao = duracao;
            Ordem = Ordem;
        }

        public void AdicionarConvidado(string convidado)
        {
            convidados.Add(convidado);

        }
    }
}