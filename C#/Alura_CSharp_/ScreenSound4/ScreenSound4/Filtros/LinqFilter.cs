using ScreenSound4.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound4.Filtros
{
    internal class LinqFilter
    {
        public static void FiltrarTodosOsGeneros(List<Musica> musicas)
        {
            var todosOsGenerosMusicais = musicas
                .Select(musicas => musicas.Genero)
                .Distinct()
                .ToList();
            foreach( var genero in todosOsGenerosMusicais)
            {
                Console.WriteLine($"- {genero}");
            }
        }
        public static void FiltrarArtistasPorGenero(List<Musica> musicas, string genero)
        {
            var artistasPorGenero = musicas
                .Where(musica => musica.Genero!
                .Contains(genero))
                .Select(musica => musica.Artista)
                .Distinct()
                .ToList();
            Console.WriteLine($"Exibindo os artistas por gênero musical >>> {genero}");
            foreach(var artista in artistasPorGenero)
            {
                Console.WriteLine($"- {artista}");
            }
        }
        public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeArtista)
        {
            var musicasDoArtista = musicas
                .Where(musica => musica.Artista!.Equals(nomeArtista)).ToList();
            Console.WriteLine(nomeArtista);

            foreach(var musica in musicasDoArtista)
            {
                Console.WriteLine($"- {musica.Nome}");
            }
        }
        public static void PesquisarMusicasdoAno(List<Musica> musicas, string ano)
        {
            var MusicasdoAno = musicas
                .OrderBy(musica => musica.Ano)
                .Select(musica => musica.Nome)
                .Distinct().ToList();

            Console.WriteLine($"Músicas do ano {ano}");
            foreach (var musicaAno in MusicasdoAno)
            {
                Console.WriteLine($"- {musicaAno}");
            }
        }

        public static void PesquisarMusicasPorTonalidade(List<Musica> musicas, string tonalidade)
        {
            var musicasTom = musicas
                .Where(musica => musica.Tonalidade!.Equals(tonalidade))
                .ToList();

            Console.WriteLine($"Músicar com o tom {tonalidade}:");
            foreach(var musica  in musicasTom)
            {
                Console.WriteLine($"- {musica.Nome}");
            }
        }
        public static void FiltrarMusicasporCSharp(List<Musica> musicas)
        {
            var musicasEmCSharp = musicas.Where(musica => musica.Tonalidade.Equals("C#")).Select(musica => musica.Nome).ToList();
            Console.WriteLine("Músicar em C#:");
            foreach(var musica in musicasEmCSharp)
            {
                Console.WriteLine($"- {musica}");
            }
                
        }
    }
}
