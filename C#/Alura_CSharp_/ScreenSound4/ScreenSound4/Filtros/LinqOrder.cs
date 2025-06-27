using ScreenSound4.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound4.Filtros
{
    internal class LinqOrder
    {
        public static void ExibirListaDeArtistasOrdenados(List<Musica>musicas)
        {
            var artistasOrdenados = musicas
                .OrderBy(musica => musica.Artista)
                .Select(musica => musica.Artista)
                .Distinct()
                .ToList();

            Console.WriteLine("Lista de artistas ordenados");
            foreach(var artista in artistasOrdenados)
            {
                Console.WriteLine($"- {artista}");
            }
        }
        public static void ExibirMusicasPorAno(List<Musica> musicas)
        {
            var musicasPorAno = musicas
                .OrderBy(musica => musica.Ano)
                .ToList();

            Console.WriteLine("Músicas em ordem de Ano de Lançamento");
            foreach(var musicasAno  in musicasPorAno)
            {
                Console.WriteLine($"- {musicasAno.Nome} - {musicasAno.Ano}");
            }
        }
    }
}
