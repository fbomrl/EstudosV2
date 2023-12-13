using ScreenSound4.Filtros;
using ScreenSound4.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //musicas[1014].ExibirDetalhesdaMusica();
        Console.WriteLine("\n"+musicas.Count);
        //LinqFilter.FiltrarTodosOsGeneros(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGenero(musicas, "rock");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Linkin Park");
        //LinqOrder.ExibirMusicasPorAno(musicas);
        //LinqFilter.PesquisarMusicasdoAno(musicas, "2000");
        
        var musicasPreferidasFabio = new MusicasPreferidas("Fabio");
        musicasPreferidasFabio.AdicionarMusicasFavoritas(musicas[770]);
        musicasPreferidasFabio.AdicionarMusicasFavoritas(musicas[78]);
        musicasPreferidasFabio.AdicionarMusicasFavoritas(musicas[1120]);
        musicasPreferidasFabio.AdicionarMusicasFavoritas(musicas[1140]);
        musicasPreferidasFabio.AdicionarMusicasFavoritas(musicas[41]);

        //musicasPreferidasFabio.ExibirMusicasFavoritas();

        var musicasPreferidasFelipe = new MusicasPreferidas("Felipe");
        musicasPreferidasFelipe.AdicionarMusicasFavoritas(musicas[700]);
        musicasPreferidasFelipe.AdicionarMusicasFavoritas(musicas[800]);
        musicasPreferidasFelipe.AdicionarMusicasFavoritas(musicas[900]);
        musicasPreferidasFelipe.AdicionarMusicasFavoritas(musicas[1000]);
        musicasPreferidasFelipe.AdicionarMusicasFavoritas(musicas[1100]);

        //musicasPreferidasFelipe.ExibirMusicasFavoritas();


        LinqFilter.PesquisarMusicasPorTonalidade(musicas, "C#");

    } 
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}